using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Telefono { get; set; }
    }
}
