using Jayride.CodeChallenge.Dtos;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Interfaces.Services
{
    public interface ILocationService
    {
        Task<LocationInfoDto> GetLocationInfoByIpAsync(string ip);
    }
}
