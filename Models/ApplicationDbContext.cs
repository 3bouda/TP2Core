using Microsoft.EntityFrameworkCore;
namespace TP2Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categorie> categorie { get; set; }
        public DbSet<SousCategorie> souscategories { get; set; }
        public
        ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
        {
        }
    }
}