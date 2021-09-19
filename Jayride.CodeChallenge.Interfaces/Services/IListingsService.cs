using Jayride.CodeChallenge.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Interfaces.Services
{
    public interface IListingsService
    {
        Task<List<ListingForSearchDto>> SearchListingsAsync(int passengers);
    }
}
