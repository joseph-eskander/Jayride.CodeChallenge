using Jayride.CodeChallenge.Dtos;

namespace Jayride.CodeChallenge.Api.Models
{
    public class ListingForSearch
    {
        public ListingForSearch(ListingForSearchDto listingForSearch)
        {
            Name = listingForSearch.Name;
            PricePerPassernger = listingForSearch.PricePerPassernger;
            TotalPrice = listingForSearch.TotalPrice;
            VehicleType = new VehicleType(listingForSearch.VehicleType);
        }

        public string Name { get; set; }
        public decimal PricePerPassernger { get; set; }
        public decimal TotalPrice { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}