namespace TGC.BicycleToday.API.Models;

public class WeatherRecommendationResponse
{
	public WeatherRecommendation? HomeRecommendation { get; init; }
	public WeatherRecommendation? WorkRecommendation { get; init; }
}
