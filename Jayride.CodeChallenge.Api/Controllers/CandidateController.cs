using Jayride.CodeChallenge.Api.Models;
using Jayride.CodeChallenge.Interfaces.Services;
using System.Web.Http;

namespace Jayride.CodeChallenge.Api.Controllers
{
    public class CandidateController : ApiController
    {
        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // GET api/candidate
        public IHttpActionResult Get()
        {
            var candidate = _candidateService.GetCandidate();
            return Ok(new Candidate(candidate));
        }
    }
}