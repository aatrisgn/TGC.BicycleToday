using TGC.BicycleToday.API.Models;

namespace TGC.BicycleToday.API.Services;

public interface IDawaClient
{
	Task<AddressCoordinate> GetAddressInformationAsync(string homeAddress);
}
