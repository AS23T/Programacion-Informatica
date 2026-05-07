using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1_L_Programacion_Web.Model;

namespace WebApplication1_L_Programacion_Web.Pages
{
    public class IndexModel : PageModel
    {
        public string Mensaje { get; set; } = "";

        [BindProperty(SupportsGet = true)] //Enlazando una propiedad para los OnGet de forma verdadera; los [] son anotaciones
        public string Nombrecito {  get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string Telefono { get; set; }

        public static List<Persona> Varias_Personas = new List<Persona>();
        
        public void OnGet()
        {
            Varias_Personas.Add(new Persona { Nombre = Nombrecito, Fono = Telefono });

            Nombrecito = string.Empty;
            Telefono = string.Empty;
            ModelState.Clear();
            
        }
    }
}
