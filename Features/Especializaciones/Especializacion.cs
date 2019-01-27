using System.Collections.Generic;
using App.NETFramework.Core.Domain;
using ClinicaServicios.Features.Doctors;

namespace ClinicaServicios.Features.Especializaciones
{
    public class Especializacion : Entity
    {
        public int Id { get; set; }
        public string Nombre {get ;set; }
        
        public virtual ICollection<Doctor> Doctores {get;set;}
    }
}