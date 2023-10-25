using Microsoft.EntityFrameworkCore;
using Videojuego.Models;

namespace practicadetaller.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options) : base(options) { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Videojuegos> Videojuegos { get; set; }
    }
}