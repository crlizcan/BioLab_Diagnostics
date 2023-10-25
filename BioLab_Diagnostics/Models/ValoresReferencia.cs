using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class ValoresReferencia
    {
        public int IdReferencia { get; set; }
        public int IdPrueba { get; set; }
        public string Sexo { get; set; }
        public string ValorReferencia { get; set; }

        public virtual Pruebas IdPruebaNavigation { get; set; }
    }
}
