using System.Collections.Generic;

namespace Jayride.CodeChallenge.ServiceAgents.Listings.Models.Responses
{
    public class SearchListingsResponse
    {
        public string from { get; set; }
        public string to { get; set; }
        public List<Listing> listings { get; set; }
    }
}
