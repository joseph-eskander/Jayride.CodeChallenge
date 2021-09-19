using Jayride.CodeChallenge.Dtos;

namespace Jayride.CodeChallenge.Api.Models
{
    public class LocationInfo
    {
        public LocationInfo(LocationInfoDto locationInfoDto)
        {
            CountryCode = locationInfoDto.CountryCode;
            CountryName = locationInfoDto.CountryName;
            RegionCode = locationInfoDto.RegionCode;
            RegionName = locationInfoDto.RegionName;
            City = locationInfoDto.City;
            Zip = locationInfoDto.Zip;
            Latitude = locationInfoDto.Latitude;
            Longitude = locationInfoDto.Longitude;
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}