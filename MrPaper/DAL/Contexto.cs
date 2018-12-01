
using MrPaper.Entidades;
using System.Data.Entity;

namespace MrPaper.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Compras> Compras { get; set; }
        
        public Contexto() : base("ConStr")
        {

        }
    }
}
