using Newtonsoft.Json;
using Roomie_Client.Models;
using System.Text;

namespace Roomie_Client.API;

public class UsuarioAPI
{
    public async Task<UsuarioViewModel> Login(string email, string senha)
    {
        HttpClient client = new HttpClient();

        var response = await client.GetAsync($"http://localhost:5291/api/Usuario/email?email={email}&senha?senha={senha}");
        var json = await response.Content.ReadAsStringAsync();

        UsuarioViewModel? usuario = JsonConvert.DeserializeObject<UsuarioViewModel?>(json);

        return usuario;
    }

    public async Task Create(UsuarioViewModel usuario)
    {
        HttpClient client = new HttpClient();

        string json = JsonConvert.SerializeObject(usuario);
        StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

        // O método "Post As Json Async estava lançando um erro, com o método Post Async ele foi normalmente
        var response = client.PostAsync("http://localhost:5291/api/Usuario", body);
        
    }

}
