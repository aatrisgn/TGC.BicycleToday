using Microsoft.AspNetCore.Mvc;
using TGC.Cosmos.Abstractions;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/user/preferences")]
[ApiController]
public class UserPreferencesController : ControllerBase
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
	public async Task<UserPreferences> Get(Guid userId)
	{
		return await _userPreferencesRepository.GetByIdAsync(userId.ToString());
	}

	[HttpPost("{userId}")]
	public async Task<UserPreferences> Create(Guid userId, [FromBody] UserPreferences userPreferences)
	{
		return await _userPreferencesRepository.CreateAsync(userPreferences);
	}

	[HttpPut("{userId}")]
	public Task Update(Guid userId)
	{
		throw new NotImplementedException();
	}
}
