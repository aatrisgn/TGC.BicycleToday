namespace TGC.BicycleToday.API.Models;

public class ClientConfigurationResponse
{
	public Guid ClientId { get; set; }
	public string SignInPolicy { get; set; }
	public string ResetPasswordPolicy { get; set; }
	public string EditPolicy { get; set; }
	public string AuthorityDomain { get; set; }
}
