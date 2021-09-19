using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Services
{
    public class ListingsService : IListingsService
    {
        private readonly IListingsRepository _listingsRepository;

        public ListingsService(IListingsRepository listingsRepository)
        {
            _listingsRepository = listingsRepository;
        }

        public async Task<List<ListingForSearchDto>> SearchListingsAsync(int passengers)
        {
            var listings = await _listingsRepository.GetListingsFilteredByPassengersNumberAsync(passengers);
            return listings.Select(l => new ListingForSearchDto(l, passengers)).OrderBy(l => l.TotalPrice).ToList();
        }
    }
}