using Jayride.CodeChallenge.Dtos;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Task<LocationInfoDto> GetLocationInfoByIpAsync(string ip);
    }
}