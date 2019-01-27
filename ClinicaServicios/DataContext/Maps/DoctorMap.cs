using ClinicaServicios.Features.Doctors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicaServicios.DataContext.Maps
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctores", "Clinica");
            builder.HasKey(e => e.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired().HasColumnType("Int").UseSqlServerIdentityColumn();
            builder.Property(t => t.Nombres).HasColumnName("Nombres").IsRequired().HasColumnType("Varchar(100)").HasMaxLength(100);
            
            builder.Property(t => t.Apellidos).HasColumnName("Apellidos").IsRequired().HasColumnType("Varchar(100)").HasMaxLength(100);
            
            builder.Property(t => t.EspecialidadId).HasColumnName("EspecialidadId").IsRequired().HasColumnType("int");

            builder.Property(r => r.FechaTransaccion).HasColumnName("FechaTransaccion").IsRequired().HasColumnType("DateTime").HasDefaultValueSql("getdate()");
            builder.Property(r => r.ModificadoPor).HasColumnName("ModificadoPor").IsRequired().HasColumnType("Varchar(20)").HasMaxLength(20);


            builder.HasOne(e => e.Especializacion).WithMany(e => e.Doctores).HasForeignKey(e => e.EspecialidadId);
        }
    }
}