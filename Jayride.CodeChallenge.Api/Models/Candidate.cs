using Jayride.CodeChallenge.Dtos;

namespace Jayride.CodeChallenge.Api.Models
{
    public class Candidate
    {
        public Candidate()
        {
        }

        public Candidate(CandidateDto candidate) : this()
        {
            Name = candidate.Name;
            Phone = candidate.Phone;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
    }
}