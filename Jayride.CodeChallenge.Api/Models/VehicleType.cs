using Jayride.CodeChallenge.Dtos;

namespace Jayride.CodeChallenge.Api.Models
{
    public class VehicleType
    {
        public VehicleType(VehicleTypeDto vehicleType)
        {
            Name = vehicleType.Name;
            MaxPassergers = vehicleType.MaxPassergers;
        }

        public string Name { get; set; }
        public int MaxPassergers { get; set; }
    }
}