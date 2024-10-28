using System.Net.Http.Json;

namespace AurumVoteSystemClient.Services
{
    public class VotingApiService
    {
        private readonly HttpClient _httpClient;

        public VotingApiService(HttpClient httpClient)
        {
            // 서버의 기본 주소를 설정 (예: https://localhost:5001)
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7158"); // 실제 서버 주소로 변경
        }

        public async Task<List<VoteItem>> GetVoteItemsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<VoteItem>>("api/voting/items");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        //public async Task<bool> VoteAsync(string username, string itemName)
        //{
        //    var response = await _httpClient.PostAsync($"api/voting/vote?username={username}&itemName={itemName}", null);
        //    return response.IsSuccessStatusCode;
        //}

        public async Task<HttpResponseMessage> VoteAsync(string username, string itemName)
        {
            var url = $"api/voting/vote?username={username}&itemName={itemName}";
            return await _httpClient.PostAsync(url, null); // 응답을 HttpResponseMessage로 반환
        }

        public async Task<Dictionary<string, double>> GetVoteResultsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Dictionary<string, double>>("api/voting/results");
        }
    }

    public class VoteItem
    {
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}
