using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationPost.Pages
{
    public class PrivacyModel : PageModel
    {
        public string InfoRecibida { get; set; }

        public void OnGet()
        {
            // Extraemos el valor de TempData
            // Al leerlo, TempData se marca para ser eliminado en la próxima petición

            InfoRecibida = HttpContext.Session.GetString("MensajeCompartido") ?? "Sin datos aun";
        }
    }

}
