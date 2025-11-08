using System.Net.Http;

namespace PotterDbApi
{
    public class PotterDb
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.potterdb.com/v1";
        public PotterDb()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetCharacters()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/characters");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBooks()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/books");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetChapters()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/chapters");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/movies");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetPotions()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/potions");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSpells()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/spells");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
