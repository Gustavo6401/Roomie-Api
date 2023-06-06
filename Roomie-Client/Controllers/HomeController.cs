using Microsoft.AspNetCore.Mvc;
using Roomie_Client.API;
using Roomie_Client.Models;
using System.Diagnostics;

namespace Roomie_Client.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            QuartoAPI api = new QuartoAPI();
            var listaQuartos = await api.GetAllAsync();    
            
            if(listaQuartos == null) { return NotFound(); }

            return View(listaQuartos);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}