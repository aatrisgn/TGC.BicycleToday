using TGC.Cosmos.Models;

namespace TGC.BicycleToday.API.Models;

public class UserPreferences : RepositoryEntity
{
	public string? Title { get; set; }
	public string? Description { get; set; }
}
