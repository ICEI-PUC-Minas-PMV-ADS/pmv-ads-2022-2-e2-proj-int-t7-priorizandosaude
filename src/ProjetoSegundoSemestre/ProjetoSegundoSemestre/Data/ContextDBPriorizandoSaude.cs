using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoSegundoSemestre.Models;

namespace ProjetoSegundoSemestre.Data
{
    public class ContextDBPriorizandoSaude : DbContext
    { 

            public ContextDBPriorizandoSaude(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Paciente> Pacientes { get; set; }
            public DbSet<Medico> Medicos { get; set; }
            public DbSet<Agenda> Agendas { get; set; }
            public DbSet<Consulta> Consultas { get; set; }

    }
}
