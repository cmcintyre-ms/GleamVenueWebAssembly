using GleamVenueWebAssembly.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace GleamVenueWebAssembly.Services.GleamVenueService
{
    public class GleamVenueService : IGleamVenueService
    {
        private readonly HttpClient httpClient;

        public GleamVenueService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddNewVenue(GleamVenue gleamVenue)
        {
            var content = JsonSerializer.Serialize(gleamVenue);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await httpClient.PostAsync("api/GleamVenues", bodyContent);
            var postContent = await postResult.Content.ReadAsStringAsync();

            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
        }

        public async Task<List<GleamVenue>> GetAllGleamVenues()
        {
            return await httpClient.GetFromJsonAsync<List<GleamVenue>>("api/GleamVenues");
        }

        public async Task<GleamVenue> GetGleamVenueById(Guid id)
        {
            return await httpClient.GetFromJsonAsync<GleamVenue>($"api/GleamVenues/{id}");
        }
    }
}
