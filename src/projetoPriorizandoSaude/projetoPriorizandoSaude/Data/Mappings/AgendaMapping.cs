
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projetoPriorizandoSaude.Models;

namespace projetoPriorizandoSaude.Data.Mappings
{
    public class AgendaMapping : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataHoraInicioConsulta)
                            .IsRequired()
                            .HasColumnType("datetime");

            builder.Property(x => x.DataHoraFimConsulta)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(m => m.Medico)
                    .WithMany(a => a.Agendas);

        }
    }
}
