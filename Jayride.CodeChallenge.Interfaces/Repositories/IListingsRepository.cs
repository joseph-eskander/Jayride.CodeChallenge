using Jayride.CodeChallenge.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Interfaces.Repositories
{
    public interface IListingsRepository
    {
        Task<IEnumerable<ListingDto>> GetListingsFilteredByPassengersNumberAsync(int passengers);
    }
}
