using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using WebApplicationPost.Model;

namespace WebApplicationPost.Pages
{
    public class PrivacyModel : PageModel
    {
        public Contacto contactoRecibido;

        public void OnGet()
        {
            if (TempData["nuevoContacto"] is string json)
            {
                // Convertimos el JSON de vuelta al objeto original
                contactoRecibido = JsonSerializer.Deserialize<Contacto>(json);
            }
        }
    }

}
