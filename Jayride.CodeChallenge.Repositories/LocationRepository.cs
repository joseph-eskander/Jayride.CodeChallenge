using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.ServiceAgents.Location;
using System.Threading.Tasks;

namespace Jayride.CodeChallenge.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        // This should be configurable
        private static readonly string _ipStackApiAccessKey = "64b8c7c6ec2f83a3f4320cc5b9a99133";
        private readonly IpStackSa _ipStackSa;

        public LocationRepository()
        {
            _ipStackSa = new IpStackSa(_ipStackApiAccessKey);
        }

        public async Task<LocationInfoDto> GetLocationInfoByIpAsync(string ip)
        {
            var lookUpResponse = await _ipStackSa.LookUpAsync(ip);
            return new LocationInfoDto
            {
                CountryCode = lookUpResponse.country_code,
                CountryName = lookUpResponse.country_name,
                RegionCode = lookUpResponse.region_code,
                RegionName = lookUpResponse.region_name,
                City = lookUpResponse.city,
                Zip = lookUpResponse.zip,
                Latitude = lookUpResponse.latitude,
                Longitude = lookUpResponse.longitude,
            };
        }


    }
}