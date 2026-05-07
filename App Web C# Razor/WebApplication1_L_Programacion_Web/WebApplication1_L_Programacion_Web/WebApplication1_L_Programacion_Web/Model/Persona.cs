namespace WebApplication1_L_Programacion_Web.Model
//En Razor Pages Model es el Control
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public string? Fono {  get; set; } //el signo de interrogacion es para no obligar entregar null. conocido como el operador de coalescencia nula.
    }
}
