using ClinicaServicios.Features.Especializaciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicaServicios.DataContext.Maps
{
    public class EspecializacionMap : IEntityTypeConfiguration<Especializacion>
    {
        public void Configure(EntityTypeBuilder<Especializacion> builder)
        {
            builder.ToTable("Especializaciones", "Clinica");
            builder.HasKey(e => e.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired().HasColumnType("Int").UseSqlServerIdentityColumn();
            builder.Property(t => t.Nombre).HasColumnName("Nombre").IsRequired().HasColumnType("Varchar(50)").HasMaxLength(50);
            builder.Property(r => r.FechaTransaccion).HasColumnName("FechaTransaccion").IsRequired().HasColumnType("DateTime").HasDefaultValueSql("getdate()");
            builder.Property(r => r.ModificadoPor).HasColumnName("ModificadoPor").IsRequired().HasColumnType("Varchar(20)").HasMaxLength(20);

        }
    }
}