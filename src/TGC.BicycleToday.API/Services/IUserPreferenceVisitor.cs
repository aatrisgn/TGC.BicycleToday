using TGC.BicycleToday.API.Models;

namespace TGC.BicycleToday.API.Services;

public interface IUserPreferenceVisitor
{
	Task AdjustForUserPreferencesAsync(string userIdentifier, WeatherRecommendation combinedWeatherRecomendation);
}
