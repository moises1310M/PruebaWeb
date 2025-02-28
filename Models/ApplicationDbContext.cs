using Microsoft.EntityFrameworkCore;
using MiAppWeb.Models; // Asegúrate de que el namespace sea correcto

namespace MiAppWeb.Data // Usa el namespace correcto según tu proyecto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } // El modelo "Usuario" debe estar bien definido
    }
}

