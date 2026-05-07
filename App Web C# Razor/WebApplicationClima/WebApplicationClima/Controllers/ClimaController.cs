using Microsoft.AspNetCore.Mvc;
using WebApplicationClima.Models;

namespace WebApplicationClima.Controllers
{
    public class ClimaController : Controller
    {
        public IActionResult Lista()
        {
            var listaPronos = new List<Pronostico>()
            {
                new Pronostico
                {
                    ID = 1,
                    Ciudad = "Conce",
                    Estado = "Nublado",
                    temperatura = 19
                },

                new Pronostico
                {
                    ID = 2,
                    Ciudad = "Stgo",
                    Estado = "Humo",
                    temperatura = 19
                },
                new Pronostico
                {
                    ID = 3,
                    Ciudad = "Puente Asalto",
                    Estado = "Despejado",
                    temperatura = 19
                }
            }; 
            return View(listaPronos);
        }
    }
}
