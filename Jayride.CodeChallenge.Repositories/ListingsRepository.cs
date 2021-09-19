using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.ServiceAgents.Listings;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Repositories
{
    public class ListingsRepository : IListingsRepository
    {
        private readonly QuoteRequestSa _quoteRequestSa;

        public ListingsRepository()
        {
            _quoteRequestSa = new QuoteRequestSa();
        }

        public async Task<IEnumerable<ListingDto>> GetListingsFilteredByPassengersNumberAsync(int passengers)
        {
            var searchResponse = await _quoteRequestSa.SearchListingsAsync();
            var filteredListings = searchResponse.listings?.Where(l => l.vehicleType.maxPassengers >= passengers).ToList();
            return filteredListings.Select(l => new ListingDto
            {
                Name = l.name,
                PricePerPassernger = l.pricePerPassenger,
                VehicleType = new VehicleTypeDto
                {
                    Name = l.vehicleType.name,
                    MaxPassergers = l.vehicleType.maxPassengers
                }
            }).ToList();
        }
    }
}