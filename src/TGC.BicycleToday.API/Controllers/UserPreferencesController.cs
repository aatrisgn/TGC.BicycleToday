using Microsoft.AspNetCore.Mvc;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/user/preferences")]
[ApiController]
public class UserPreferencesController : ControllerBase
{
	[HttpGet("{userId}")]
	public Task Get(Guid userId)
	{
		throw new NotImplementedException();
	}

	[HttpPost("{userId}")]
	public Task Create(Guid userId)
	{
		throw new NotImplementedException();
	}

	[HttpPut("{userId}")]
	public Task Update(Guid userId)
	{
		throw new NotImplementedException();
	}
}
