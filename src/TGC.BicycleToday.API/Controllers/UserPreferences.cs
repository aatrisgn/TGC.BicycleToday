using TGC.Cosmos.Models;

namespace TGC.BicycleToday.API.Controllers;

public class UserPreferences : RepositoryEntity
{
	public string? Title { get; set; }
	public string? Description { get; set; }
}
