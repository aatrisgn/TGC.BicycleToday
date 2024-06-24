using TGC.BicycleToday.API.Models;

namespace TGC.BicycleToday.API.Services;

public interface IWeatherEvaluator
{
	Task<TimeSpecificWeatherRecommendation> GetTimeSpecificWeatherRecommendationAsync(AddressCoordinate addressCordinate, int startTime);
}
