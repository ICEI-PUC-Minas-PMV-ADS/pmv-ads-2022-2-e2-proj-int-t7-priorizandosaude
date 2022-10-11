
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projetoPriorizandoSaude.Models;

namespace projetoPriorizandoSaude.Data.Mappings
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StatusConsulta)
                            .IsRequired()
                            .HasColumnType("varchar(1)");

            builder.HasOne(m => m.Agenda)
                    .WithMany(a => a.Consultas);

            builder.HasOne(x => x.Paciente)
                    .WithMany(x => x.Consultas);

        }
    }
}
