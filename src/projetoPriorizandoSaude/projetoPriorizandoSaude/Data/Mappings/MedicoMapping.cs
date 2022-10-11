using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projetoPriorizandoSaude.Models;

namespace projetoPriorizandoSaude.Data.Mappings
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email)
                            .IsRequired()
                            .HasColumnType("varchar(200)");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.CRM)
                .IsRequired()
                .HasColumnType("varchar(200)");

        }
    }
}
