using listaBack.Models;
using Microsoft.EntityFrameworkCore;

namespace listaBack.Context
{
    public class AplicationDbContext: DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Tarea> Tareas { get; set; }
        // esto bindea con tareas que es el nombre de la tabla en la bdd
    }
}
