using Microsoft.AspNetCore.Mvc;
using WebApplicationCanciones.Models;

namespace WebApplicationCanciones.Controllers
{
    public class CancionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lista()
        {
            // Creamos una lista manual (Simulando una base de datos)
            var misCanciones = new List<Cancion>
            {
                new Cancion { Id = 1, Titulo = "Comfortably Numb", Banda = "Pink Floyd" },
                new Cancion { Id = 2, Titulo = "Yellow Ledbetter", Banda = "Pearl Jam" },
                new Cancion { Id = 3, Titulo = "Hells Bells", Banda = "AC/DC" }
            };

            // LE PASAMOS LA LISTA A LA VISTA
            return View(misCanciones);

        }
    }
}
