namespace TGC.BicycleToday.API.Services;

public interface IUserContext
{
	string? UserIdentifier { get; }

	bool IsAuthenticated();
}
