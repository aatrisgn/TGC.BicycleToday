using Microsoft.AspNetCore.Mvc;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/user/preferences")]
[ApiController]
public class UserPreferencesController : BaseAPIController
{
	[HttpGet("{userId}")]
	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	public Task Get(Guid userId)
	{
		throw new NotImplementedException();
	}

	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	[HttpPost("{userId}")]
	public Task Create(Guid userId)
	{
		throw new NotImplementedException();
	}

	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	[HttpPut("{userId}")]
	public Task Update(Guid userId)
	{
		throw new NotImplementedException();
	}
}
