namespace TGC.BicycleToday.API.Models;

public class AddressCoordinateSet
{
	public AddressCoordinateSet(AddressCoordinate homeAddress, AddressCoordinate workAddress)
	{
		HomeAddress = homeAddress;
		WorkAddress = workAddress;
	}

	public AddressCoordinate HomeAddress { get; set; }
	public AddressCoordinate WorkAddress { get; set; }
}
