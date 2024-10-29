using AurumVoteSystemServer.Models;

namespace AurumVoteSystemServer.Data
{
    public class VotingService
    {
        private readonly ILogger<VotingService> _logger;
        private List<VoteItem> voteItems;
        private HashSet<string> votedUsers;

        public VotingService(ILogger<VotingService> logger)
        {
            _logger = logger;
            voteItems = new List<VoteItem>
            {
                new VoteItem { Name = "Python" },
                new VoteItem { Name = "Java" },
                new VoteItem { Name = "C sharp" }
            };
            votedUsers = new HashSet<string>();
        }

        public List<VoteItem> GetVoteItems()
        {
            _logger.LogInformation("Vote items requested.");
            return voteItems;
        }

        public bool Vote(string username, string itemName)
        {
            if (votedUsers.Contains(username))
            {
                _logger.LogWarning("User {Username} has already voted.", username);
                return false;
            }


            var voteItem = voteItems.FirstOrDefault(v => v.Name == itemName);
            if (voteItem != null)
            {
                voteItem.VoteCount++;
                votedUsers.Add(username);
                _logger.LogInformation("User {Username} voted for {ItemName}.", username, itemName);
                return true;
            }
            _logger.LogWarning("Vote item {ItemName} not found.", itemName);
            return false;
        }

        public Dictionary<string, double> GetVotePercentage()
        {
            int totalVotes = voteItems.Sum(v => v.VoteCount);
            var percentages = voteItems.ToDictionary(v => v.Name, v => totalVotes > 0 ? Math.Round((double)v.VoteCount / totalVotes * 100, 1) : 0);
            _logger.LogInformation("Vote percentages calculated: {Percentages}", percentages);
            return percentages;
        }
    }
}
