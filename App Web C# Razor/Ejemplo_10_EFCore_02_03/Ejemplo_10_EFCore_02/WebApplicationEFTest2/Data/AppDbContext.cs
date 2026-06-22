using Microsoft.EntityFrameworkCore;
using WebApplicationEFTest2.Models;

namespace WebApplicationEFTest2.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public AppDbContext(DbContextOptions options) : 
            base(options)
        {

        }


    }
}
