using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class Pruebas
    {
        public Pruebas()
        {
            PeticionesPruebas = new HashSet<PeticionesPruebas>();
            ValoresReferencia = new HashSet<ValoresReferencia>();
        }

		public int IdPrueba { get; set; }
		[Required(ErrorMessage = "El campo Nombre es obligatorio")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "El campo Descripción es obligatorio")]
		public string Descripcion { get; set; }
		[Required(ErrorMessage = "El campo Precio es obligatorio")]
		[RegularExpression(@"^\d+(\,\d{1,2})?$", ErrorMessage = "Ingrese un número válido con hasta dos decimales.")]
		public decimal Precio { get; set; }
		public int IdDepartamento { get; set; }
		//[Required(ErrorMessage = "El campo Unidades es obligatorio")]
		public string Unidades { get; set; }
		public bool? EsActivo { get; set; }

        public virtual Departamentos IdDepartamentoNavigation { get; set; }
        public virtual ICollection<PeticionesPruebas> PeticionesPruebas { get; set; }
        public virtual ICollection<ValoresReferencia> ValoresReferencia { get; set; }
    }
}
