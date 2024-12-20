using DS_projekat_frontend.Models;
using System.Net.Http.Json;

namespace DS_projekat_frontend.Services
{
    public class PosiljkaService
    {
        private readonly HttpClient _httpClient;

        public PosiljkaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Posiljka>> GetAllPosiljkeAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Posiljka>>("/posiljke") ?? new List<Posiljka>();
        }

        public async Task<Posiljka?> GetPosiljkaByIdAsync(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<Posiljka>($"/posiljke/{id}");
        }

        public async Task<bool> CreatePosiljkaAsync(Posiljka posiljka)
        {
            var response = await _httpClient.PostAsJsonAsync("/posiljke", posiljka);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePosiljkaAsync(Guid id, Posiljka posiljka)
        {
            var response = await _httpClient.PutAsJsonAsync($"/posiljke/{id}", posiljka);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePosiljkaAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"/posiljke/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
