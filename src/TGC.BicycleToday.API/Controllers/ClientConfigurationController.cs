using Microsoft.AspNetCore.Mvc;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/configuration/client")]
[ApiController]
public class ClientConfigurationController : BaseAPIController
{
	public Task<ClientConfigurationResponse> GetClientConfiguration()
	{
		return Task.FromResult(new ClientConfigurationResponse());
	}
}
