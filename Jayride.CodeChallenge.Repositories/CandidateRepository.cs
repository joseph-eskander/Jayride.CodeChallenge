using Jayride.CodeChallenge.Data;
using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jayride.CodeChallenge.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        public CandidateDto GetCandidate()
        {
            Random r = new Random();
            var candidate = GetAllCandidates().OrderBy(x => r.Next()).FirstOrDefault();
            return candidate != null ? new CandidateDto
            {
                Id = candidate.Id,
                Name = candidate.Name,
                Phone = candidate.Phone
            } : null;
        }

        private IEnumerable<Candidate> GetAllCandidates()
        {
            return new List<Candidate>() {
                new Candidate
                {
                    Id=1,
                    Name="Name1",
                    Phone="Phone1",
                },
                new Candidate {
                    Id=1,
                    Name="Name2",
                    Phone="Phone2",
                }
            };
        }
    }
}