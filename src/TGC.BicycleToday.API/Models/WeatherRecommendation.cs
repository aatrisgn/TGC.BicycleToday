namespace TGC.BicycleToday.API.Models;

public class WeatherRecommendation
{
	public WeatherRecommendation(TimeSpecificWeatherRecommendation startTimeSpecificWeatherRecommendation, TimeSpecificWeatherRecommendation endTimeSpecificWeatherRecommendation)
	{
		StartTimeSpecificWeatherRecommendation = startTimeSpecificWeatherRecommendation;
		EndTimeSpecificWeatherRecommendation = endTimeSpecificWeatherRecommendation;
	}

	TimeSpecificWeatherRecommendation StartTimeSpecificWeatherRecommendation { get; set; }
	TimeSpecificWeatherRecommendation EndTimeSpecificWeatherRecommendation { get; set; }
}
