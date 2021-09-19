using Jayride.CodeChallenge.Api.Models;
using Jayride.CodeChallenge.Interfaces.Services;
using System.Threading.Tasks;
using System.Web.Http;

namespace Jayride.CodeChallenge.Api.Controllers
{
    public class LocationController : ApiController
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        // Ideally the IP should come from the request itself
        public async Task<IHttpActionResult> GetAsync(string ip)
        {
            var locationInfo = await _locationService.GetLocationInfoByIpAsync(ip);
            return Ok(new LocationInfo(locationInfo));
        }
    }
}
