using System.Net.Http.Json;

namespace CRM_App.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CustomersType>> GetCustomers()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-customers.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CustomersType>>().ConfigureAwait(false);
            }

            return new List<CustomersType>();
        }
    }
}