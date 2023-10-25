using System;
using System.Collections.Generic;

namespace BioLab_Diagnostics.Models
{
    public partial class Peticiones
    {
        public Peticiones()
        {
            PeticionesPruebas = new HashSet<PeticionesPruebas>();
        }

        public int IdPeticion { get; set; }
        public string DniCliente { get; set; }
        public DateTime FechaVisita { get; set; }
        public DateTime? FechaInforme { get; set; }
        public decimal Importe { get; set; }
        public string Estado { get; set; }

        public virtual Clientes DniClienteNavigation { get; set; }
        public virtual ICollection<PeticionesPruebas> PeticionesPruebas { get; set; }
    }
}
