using AT.Client.Services.Interface;
using AT.Share.Model;
using System.Net.Http.Json;
namespace AT.Client.Services.ProgressHistory
{
    public class TaskProgressHistoryService : ITaskProgressHistoryService
    {
        private readonly HttpClient _httpClient;
        public TaskProgressHistoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task PostTaskProgressHistoryAsync(TaskProgressHistory taskProgressHistory)
        {
            await _httpClient.PostAsJsonAsync("/api/TaskProgressHistory",taskProgressHistory);
        }
    }
}
