using Microsoft.EntityFrameworkCore;
using projetoPriorizandoSaude.Models;

namespace projetoPriorizandoSaude.Data
{
    public class ContextPriorizandoSaude : DbContext
    {
        public ContextPriorizandoSaude(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Medico> Medicos { get; set; }
       public DbSet<Paciente> Paciente { get; set; }
       public DbSet<Consulta> Consulta { get; set; }
       public DbSet<Agenda> Agenda { get; set; }




    }
}
