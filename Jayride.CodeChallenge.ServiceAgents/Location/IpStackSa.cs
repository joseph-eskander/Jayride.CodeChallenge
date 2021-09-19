using Jayride.CodeChallenge.ServiceAgents.Location.Models.Responses;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.ServiceAgents.Location
{
    public class IpStackSa
    {
        private readonly string _accessKey;

        public IpStackSa(string accessKey)
        {
            _accessKey = accessKey;   
        }

        public async Task<LookUpResponse> LookUpAsync(string ip)
        {
            using (var client=new HttpClient())
            {
                var response = await client.GetAsync($"http://api.ipstack.com/{ip}?access_key={_accessKey}");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<LookUpResponse>(responseContent);
                }

                // Better error handling should be implemented by parsing the response content.
                throw new HttpRequestException($"IP look up failed with response code {response.StatusCode}");
            }
        }
    }
}
