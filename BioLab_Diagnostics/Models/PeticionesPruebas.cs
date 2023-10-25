using System;
using System.Collections.Generic;

namespace BioLab_Diagnostics.Models
{
    public partial class PeticionesPruebas
    {
        public int IdPeticionPrueba { get; set; }
        public int IdPeticion { get; set; }
        public int IdPrueba { get; set; }
        public string Resultado { get; set; }

        public virtual Peticiones IdPeticionNavigation { get; set; }
        public virtual Pruebas IdPruebaNavigation { get; set; }
    }
}
