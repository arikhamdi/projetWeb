using Microsoft.EntityFrameworkCore;
using projetWeb.Models;

namespace projetWeb.Models
{
    public class EstablishmentContext : DbContext
    {
        public EstablishmentContext(DbContextOptions<EstablishmentContext> options) : base(options)
        {

        }

        public DbSet<Establishment> Establishments { get; set; }

    }
}
