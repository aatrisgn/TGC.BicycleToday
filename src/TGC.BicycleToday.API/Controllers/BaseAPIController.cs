using Microsoft.AspNetCore.Mvc;

namespace TGC.BicycleToday.API.Controllers;
[Route("api/[controller]")]
[ApiController]
[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status403Forbidden)]
public class BaseAPIController : ControllerBase
{
}
