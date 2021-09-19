namespace Jayride.CodeChallenge.ServiceAgents.Listings.Models.Responses
{
    public class Listing
    {
        public string name { get; set; }
        public decimal pricePerPassenger { get; set; }
        public VehicleType vehicleType { get; set; }
    }
}
