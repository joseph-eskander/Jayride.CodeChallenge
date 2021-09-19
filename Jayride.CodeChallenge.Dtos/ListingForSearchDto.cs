namespace Jayride.CodeChallenge.Dtos
{
    public class ListingForSearchDto : ListingDto
    {
        public ListingForSearchDto(ListingDto listing, int passengers)
        {
            Name = listing.Name;
            PricePerPassernger = listing.PricePerPassernger;
            VehicleType = listing.VehicleType;
            TotalPrice = PricePerPassernger * passengers;
        }

        public decimal TotalPrice { get; set; }
    }
}