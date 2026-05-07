namespace WebApplicationCanciones.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public required string Titulo { get; set; } 
        public required string Banda { get; set; }
    }

}
