using AurumVoteSystemServer.Models;

namespace AurumVoteSystemServer.Data
{
    public class VotingService
    {
        private List<VoteItem> voteItems;
        private HashSet<string> votedUsers;

        public VotingService()
        {
            voteItems = new List<VoteItem>
            {
                new VoteItem { Name = "Python" },
                new VoteItem { Name = "Java" },
                new VoteItem { Name = "C sharp" }
            };
            votedUsers = new HashSet<string>();
        }

        public List<VoteItem> GetVoteItems() => voteItems;

        public bool Vote(string username, string itemName)
        {
            if (votedUsers.Contains(username))
                return false;

            var voteItem = voteItems.FirstOrDefault(v => v.Name == itemName);
            if (voteItem != null)
            {
                voteItem.VoteCount++;
                votedUsers.Add(username);
                return true;
            }
            return false;
        }

        public Dictionary<string, double> GetVotePercentage()
        {
            int totalVotes = voteItems.Sum(v => v.VoteCount);
            return voteItems.ToDictionary(v => v.Name, v => totalVotes > 0 ? (double)v.VoteCount / totalVotes * 100 : 0);
        }
    }
}
