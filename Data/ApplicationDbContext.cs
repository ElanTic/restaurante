using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using restaurante.Models;

namespace restaurante.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<restaurante.Models.Categoria>? Categoria { get; set; }
        public DbSet<restaurante.Models.Producto>? Producto { get; set; }
    }
}