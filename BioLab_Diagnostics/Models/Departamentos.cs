using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Pruebas = new HashSet<Pruebas>();
        }

        public int IdDepartamento { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Descripción es obligatorio")]
        public string Descripcion { get; set; }

        public virtual ICollection<Pruebas> Pruebas { get; set; }
    }
}
