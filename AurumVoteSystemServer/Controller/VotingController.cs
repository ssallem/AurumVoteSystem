using AurumVoteSystemServer.Data;
using AurumVoteSystemServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AurumVoteSystemServer.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotingController : ControllerBase
    {
        private readonly VotingService _votingService;

        public VotingController(VotingService votingService)
        {
            _votingService = votingService;
        }


        // POST /api/voting/items
        [HttpGet("items")]
        public IEnumerable<VoteItem> GetVoteItems()
        {
            return _votingService.GetVoteItems();
        }

        // POST /api/voting/vote
        [HttpPost("vote")]
        public IActionResult Vote([FromQuery] string username, [FromQuery] string itemName)
        {
            if (_votingService.Vote(username, itemName))
                return Ok();
            return BadRequest("You have already voted.");
        }

        // POST /api/voting/results
        [HttpGet("results")]
        public Dictionary<string, double> GetVoteResults()
        {
            return _votingService.GetVotePercentage();
        }
    }
}
