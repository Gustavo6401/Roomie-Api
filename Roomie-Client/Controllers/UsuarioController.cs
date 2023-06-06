using Microsoft.AspNetCore.Mvc;
using Roomie_Client.API;
using Roomie_Client.Models;

namespace Roomie_Client.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string senha)
        {
            UsuarioAPI api = new UsuarioAPI();
            var vm = api.Login(email, senha);

            if(vm != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,EMail,Senha,Telefone,Cidade,UF,Rua,Bairro,CEP,Numero,Role,Universidade,Curso,Quartos,Reservas")] UsuarioViewModel usuario)
        {
            usuario.Quartos = null;
            usuario.Reservas = null;

            UsuarioAPI api = new UsuarioAPI();
            await api.Create(usuario);

            return RedirectToAction(nameof(Login));
        }
    }
}
