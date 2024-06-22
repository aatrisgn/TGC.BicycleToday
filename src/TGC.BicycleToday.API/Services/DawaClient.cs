using TGC.BicycleToday.API.Models;

namespace TGC.BicycleToday.API.Services;

public class DawaClient : IDawaClient
{
	private readonly IHttpClientFactory _httpClientFactory;

	public DawaClient(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}

	public Task<AddressCoordinate> GetAddressInformationAsync(string homeAddress)
	{
		// Help users with finding their correct address by using: https://api.dataforsyningen.dk/adresser?q=%C3%A5landsgade+45&format=json&srid=4326 endpoint
		// Then with the ID fetched, call https://api.dataforsyningen.dk/adresser?id=0a3f50a1-f450-32b8-e044-0003ba298018&format=json&srid=4326 to get the specific address
		// In the response use adgangsadresse.adgangspunkt[0] and adgangsadresse.adgangspunkt[1] for fetching the coordinates of the address.
		// Return these two values.

		var httpClient = _httpClientFactory.CreateClient();


		throw new NotImplementedException();
	}
}
