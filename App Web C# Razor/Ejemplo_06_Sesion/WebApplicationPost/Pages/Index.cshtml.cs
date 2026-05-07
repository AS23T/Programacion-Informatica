using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationPost.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string MensajeUsuario { get; set; }

        public void OnGet()
        {
            // Se ejecuta al cargar la página por primera vez
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(MensajeUsuario))
            {
                // Uso de ViewData y ViewBag (Solo duran la petición actual)
                ViewData["Error"] = "El campo no puede estar vacío. Por favor, escribe algo.";
                return Page(); // Recarga la misma página (mantiene ViewData/ViewBag)
            }

            // Uso de TempData (Sobrevive a la redirección)
            HttpContext.Session.SetString("MensajeCompartido", MensajeUsuario);
            
            return RedirectToPage("Privacy"); // Redirige a la otra página
        }
    }
}
