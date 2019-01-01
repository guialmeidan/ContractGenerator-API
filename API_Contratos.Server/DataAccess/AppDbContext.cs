using API_Contratos.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Contratos.Server.DataAccess
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Approveds> Approveds { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
