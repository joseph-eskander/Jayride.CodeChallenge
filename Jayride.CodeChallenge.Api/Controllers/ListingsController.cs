using Jayride.CodeChallenge.Api.Models;
using Jayride.CodeChallenge.Interfaces.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Jayride.CodeChallenge.Api.Controllers
{
    public class ListingsController : ApiController
    {
        private readonly IListingsService _listingService;

        public ListingsController(IListingsService listingsService)
        {
            _listingService = listingsService;
        }

        public async Task<IHttpActionResult> GetAsync(int passengers)
        {
            var listingsSearchResults = await _listingService.SearchListingsAsync(passengers);
            return Ok(listingsSearchResults.Select(l => new ListingForSearch(l)).ToList());
        }
    }
}
