using BioLab_Diagnostics.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace BioLab_Diagnostics.Data
{
    public class Usuario: IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string Imagen { get; set; } //Guardo la ruta a la imagen


	}
}
