using App.NETFramework.Data;
using ClinicaServicios.DataContext.Maps;
using ClinicaServicios.Features.Doctors;
using ClinicaServicios.Features.Especializaciones;
using Microsoft.EntityFrameworkCore;

namespace ClinicaServicios.DataContext
{
    public class ClinicContext : BCUnitOfWork, IClinicContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {
            
        }
         public DbSet<Especializacion> Especializaciones { get; set; }
         public DbSet<Doctor> Doctores {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EspecializacionMap());
            modelBuilder.ApplyConfiguration(new DoctorMap());
        }
    }
}