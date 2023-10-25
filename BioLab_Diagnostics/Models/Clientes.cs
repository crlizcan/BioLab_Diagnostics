using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Peticiones = new HashSet<Peticiones>();
        }
        [Required(ErrorMessage = "El campo DNI es obligatorio")]
		[StringLength(9, ErrorMessage = "La longitud debe de ser 9 caracteres")]
        public string Dni { get; set; }
		[Required(ErrorMessage = "El campo Nombre es obligatorio")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "El campo Apellidos es obligatorio")]
		public string Apellidos { get; set; }
		[Required(ErrorMessage = "El campo Fecha de nacimiento es obligatorio")]
        [DataType(DataType.Date)]
		public DateTime? FechaNacimiento { get; set; }
		public string Sexo { get; set; }
		[Required(ErrorMessage = "El campo Telefono es obligatorio")]
        [MinLength(9, ErrorMessage = "La longitud mínima es de 9 caracteres")]
        [MaxLength(11, ErrorMessage = "La longitud máxima es de 11 caracteres")]
        public string Telefono { get; set; }
		[Required(ErrorMessage = "El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
		public string Email { get; set; }

        public virtual ICollection<Peticiones> Peticiones { get; set; }
    }
}
