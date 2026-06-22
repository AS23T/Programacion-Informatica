using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEFTest2.Data;
using WebApplicationEFTest2.Models;

namespace WebApplicationEFTest2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
            /*
            _context.Contactos.Add(new Contacto { Nombre = "Koke", Email = "koke@a.b" });
            _context.Contactos.Add(new Contacto { Nombre = "Pepe", Email = "pepe@a.b" });
            _context.Contactos.Add(new Contacto { Nombre = "Lucho", Email = "lucho@a.b" });
            _context.SaveChanges();
            */
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            List<Contacto> l = _context.Contactos.ToList();
            return View(l);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
