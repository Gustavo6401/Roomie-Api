using Newtonsoft.Json;
using Roomie_Client.Models;
using System.Text.Json.Serialization;

namespace Roomie_Client.API
{
    public class QuartoAPI
    {
        public async Task<List<QuartoViewModel>> GetAllAsync()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost:5291/api/Usuario");
            var json = await response.Content.ReadAsStringAsync();

            List<QuartoViewModel>? listaQuartos = JsonConvert.DeserializeObject<List<QuartoViewModel>>(json);

            return listaQuartos;
        }
    }
}
