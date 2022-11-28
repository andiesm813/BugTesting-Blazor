using System.Net.Http.Json;

namespace Bugs_in_Samples.TravelApp
{
    public class TravelAppService
    {
        private readonly HttpClient http;

        public TravelAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<SelectedArticlesType[]?> GetSelectedArticles()
        {
            return await http.GetFromJsonAsync<SelectedArticlesType[]>("/static-data/travel-app-selected-articles.json");
        }
    }
}