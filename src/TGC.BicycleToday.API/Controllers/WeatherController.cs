using Microsoft.AspNetCore.Mvc;
using TGC.BicycleToday.API.Models;
using TGC.BicycleToday.API.Services;

namespace TGC.BicycleToday.API.Controllers;

[Route("api/weather")]
[ApiController]
public class WeatherController : BaseAPIController
{
	private readonly IWeatherRecommendationService _weatherRecommendationService;
	public WeatherController(IWeatherRecommendationService weatherRecommendationService)
	{
		_weatherRecommendationService = weatherRecommendationService;
	}

	[HttpGet("recommendation/{homeAddress}/{workAddress}")]
	public async Task<WeatherRecommendationResponse> GetWeatherRecommendation(string homeAddress, string workAddress)
	{
		return await _weatherRecommendationService.GetWeatherRecommendation(homeAddress, workAddress);
	}
}
