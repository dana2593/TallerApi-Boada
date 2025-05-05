using Newtonsoft.Json;

namespace TallerApi_Boada.Repositories
{
    public class CountryRepository
    {
        private HttpClient _httpClient;
        public CountryRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Country>> GetCountryList()
        {
            string url = "https://restcountries.com/v3.1/all\r\n";
            var response = await _httpClient.GetStringAsync(url);
            List<Country> countryList = JsonConvert.DeserializeObject<List<Country>>(response);
            return countryList;
        }

    }
}
