using Microsoft.AspNetCore.Mvc;
using TGC.BicycleToday.API.Models;
using TGC.Cosmos.Abstractions;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/user/preferences")]
[ApiController]
public class UserPreferencesController : BaseAPIController
{
	private readonly ICosmosRepository<UserPreferences> _userPreferencesRepository;

	public UserPreferencesController(ICosmosRepository<UserPreferences> userPreferencesRepository)
	{
		_userPreferencesRepository = userPreferencesRepository;
	}

	[HttpGet]
	public async Task<IEnumerable<UserPreferences>> GetAll(Guid userId)
	{
		return await _userPreferencesRepository.GetAllAsync();
	}

	[HttpGet("{userId}")]
	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	public async Task<UserPreferences> Get(Guid userId)
	{
		return await _userPreferencesRepository.GetByIdAsync(userId.ToString());
	}

	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	[HttpPost("{userId}")]
	public async Task<UserPreferences> Create(Guid userId, [FromBody] UserPreferences userPreferences)
	{
		return await _userPreferencesRepository.CreateAsync(userPreferences);
	}

	[ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
	[HttpPut("{userId}")]
	public Task Update(Guid userId)
	{
		throw new NotImplementedException();
	}
}
