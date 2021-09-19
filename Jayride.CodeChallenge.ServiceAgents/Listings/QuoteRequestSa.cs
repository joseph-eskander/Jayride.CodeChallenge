using Jayride.CodeChallenge.ServiceAgents.Listings.Models.Responses;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.ServiceAgents.Listings
{
    public class QuoteRequestSa
    {
        public async Task<SearchListingsResponse> SearchListingsAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<SearchListingsResponse>(responseContent);
                }

                // Better error handling should be implemented by parsing the response content.
                throw new HttpRequestException($"Listings Search failed with response code {response.StatusCode}");
            }
        }
    }
}
