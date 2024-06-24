using TGC.BicycleToday.API.Models;

namespace TGC.BicycleToday.API.Services;

public interface IWeatherRecommendationService
{
	Task<WeatherRecommendationResponse> GetWeatherRecommendation(string homeAddress, string workAddress);
}
