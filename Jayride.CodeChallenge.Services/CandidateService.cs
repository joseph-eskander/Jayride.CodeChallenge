using Jayride.CodeChallenge.Dtos;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.Interfaces.Services;

namespace Jayride.CodeChallenge.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public CandidateDto GetCandidate()
        {
            return _candidateRepository.GetCandidate();
        }
    }
}
