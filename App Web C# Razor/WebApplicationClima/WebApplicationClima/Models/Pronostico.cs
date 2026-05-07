namespace WebApplicationClima.Models
{
    public class Pronostico
    {
        public int ID { get; set; }
        public required string Ciudad { get; set; }
        public required string Estado { get; set; }
        public float temperatura { get; set; } 
    }
}
