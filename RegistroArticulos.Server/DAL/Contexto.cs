using Ap1_P1_JairoCamilo.Models;
using Microsoft.EntityFrameworkCore;

namespace RegistroArticulos.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
