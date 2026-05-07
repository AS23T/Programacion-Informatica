using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using WebApplicationPost.Model;

namespace WebApplicationPost.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public string Mail { get; set; }
        public void OnGet()
        {
            // Se ejecuta al cargar la página por primera vez
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Mail)|| string.IsNullOrEmpty(Nombre))
            {
                // Uso de ViewData y ViewBag (Solo duran la petición actual)
                ViewData["Error"] = "El campo no puede estar vacío. Por favor, escribe algo.";
                return Page(); // Recarga la misma página (mantiene ViewData/ViewBag)
            }

            var nuevoContacto = new Contacto { Nombre = this.Nombre, Mail = this.Mail};

            // Convertimos el objeto a una cadena de texto JSON
            TempData["nuevoContacto"] = JsonSerializer.Serialize(nuevoContacto);

            return RedirectToPage("Privacy"); // Redirige a la otra página
        }
    }
}
