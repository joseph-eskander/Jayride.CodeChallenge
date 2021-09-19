using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.Interfaces.Services;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<LocationInfoDto> GetLocationInfoByIpAsync(string ip)
        {
            return await _locationRepository.GetLocationInfoByIpAsync(ip);
        }
    }
}
