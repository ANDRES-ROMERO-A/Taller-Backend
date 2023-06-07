using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace RomeroAlvarado.API.Models
{
    public class SalesDB2023DbContext: DbContext
    {
       public SalesDB2023DbContext()
        {

        }
        public SalesDB2023DbContext(DbContextOptions<SalesDB2023DbContext> options) : base(options)
        {
            
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
    }
}
