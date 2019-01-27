using App.NETFramework.Core.Domain;
using ClinicaServicios.Features.Especializaciones;

namespace ClinicaServicios.Features.Doctors
{
    public class Doctor : Entity
    {
        public int Id { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }   
        public int EspecialidadId {get;set;}

        public virtual Especializacion Especializacion {get;set;}
    
    }
}