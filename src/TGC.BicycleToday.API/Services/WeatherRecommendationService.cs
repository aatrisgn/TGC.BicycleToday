using TGC.BicycleToday.API.Models;
using TGC.Common.Exceptions;
using TGC.Common.Exceptions.Http;

namespace TGC.BicycleToday.API.Services;

public class WeatherRecommendationService : IWeatherRecommendationService
{
	private readonly IDawaClient _dawaClient;
	private readonly IWeatherEvaluator _weatherEvaluator;
	private readonly IUserPreferenceVisitor _userPreferenceVisitor;
	private readonly IUserContext _userContext;

	public WeatherRecommendationService(IDawaClient dawaClient, IWeatherEvaluator weatherEvaluator, IUserPreferenceVisitor userPreferenceVisitor, IUserContext userContext)
	{
		_dawaClient = dawaClient;
		_weatherEvaluator = weatherEvaluator;
		_userPreferenceVisitor = userPreferenceVisitor;
		_userContext = userContext;
	}

	public async Task<WeatherRecommendationResponse> GetWeatherRecommendation(string homeAddress, string workAddress)
	{
		var addressCordinateSet = await GetCoordinateSetByAddressesAsync(homeAddress, workAddress);

		var weatherRecommendationHome = await GetWeatherRecommendationForAddressInTimespanAsync(addressCordinateSet.HomeAddress, 8, 16);
		var weatherRecommendationWork = await GetWeatherRecommendationForAddressInTimespanAsync(addressCordinateSet.WorkAddress, 8, 16);

		return new WeatherRecommendationResponse
		{
			HomeRecommendation = weatherRecommendationHome,
			WorkRecommendation = weatherRecommendationWork
		};
	}

	private async Task<AddressCoordinateSet> GetCoordinateSetByAddressesAsync(string homeAddress, string workAddress)
	{
		AddressCoordinate homeAddressDawaResponse = await _dawaClient.GetAddressInformationAsync(homeAddress);
		AddressCoordinate workAddressDawaResponse = await _dawaClient.GetAddressInformationAsync(workAddress);

		var addressCordinateSet = new AddressCoordinateSet(homeAddressDawaResponse, workAddressDawaResponse);

		return addressCordinateSet;
	}

	public async Task<WeatherRecommendation> GetWeatherRecommendationForAddressInTimespanAsync(AddressCoordinate addressCordinate, int startTime, int endTime)
	{
		TimeSpecificWeatherRecommendation timeSpecificWeatherRecommendationAtStartTime = await _weatherEvaluator.GetTimeSpecificWeatherRecommendationAsync(addressCordinate, startTime);
		TimeSpecificWeatherRecommendation timeSpecificWeatherRecommendationAtEndtime = await _weatherEvaluator.GetTimeSpecificWeatherRecommendationAsync(addressCordinate, endTime);

		var combinedWeatherRecomendation = new WeatherRecommendation(timeSpecificWeatherRecommendationAtStartTime, timeSpecificWeatherRecommendationAtEndtime);

		if (_userContext.IsAuthenticated())
		{
			HttpExceptionFactory.ThrowIfNull<UnauthorizedException>(_userContext.UserIdentifier, "No user identifier was found.");
			await _userPreferenceVisitor.AdjustForUserPreferencesAsync(_userContext.UserIdentifier, combinedWeatherRecomendation);
		}

		return combinedWeatherRecomendation;
	}
}
