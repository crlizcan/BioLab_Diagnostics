using System.Drawing;

namespace BioLab_Diagnostics.Models
{
	public class PruebasValoresReferenciaViewModel
	{
		public Pruebas pruebas { get; set; }
		public int IdReferencia { get; set; }
		public int IdPrueba { get; set; }
		public string Sexo { get; set; }
		//Permite aplicar un símbolo o un rango al valor de referencia
		public string Operacion { get; set; }
		//Recoge si el valor de referencia depende del sexo del paciente. 
		//Vr_Unico = "Si" -- El valor de referencia varía en función del sexo (H/M)
		//Vr_Unico = "No" -- El valor de referencia es idéntico en ambos sexos 
		public string Vr_unico { get; set; }
		public string ValorReferencia { get; set; }
		//Para Vr_Unico="No" y Operacion="Intervalo". Recoge el inicio del intervalo.
		public string ValorReferenciaInicio { get; set; }
		//Para Vr_Unico="No" y Operacion="Intervalo". Recoge el final del intervalo.
		public string ValorReferenciaFin { get; set; }
		public string ValorReferenciaMujer { get; set; }
		public string ValorReferenciaInicioMujer { get; set; }
		public string ValorReferenciaFinMujer { get; set; }
		public string ValorReferenciaHombre { get; set; }
		public string ValorReferenciaInicioHombre { get; set; }
		public string ValorReferenciaFinHombre { get; set; }

	}
}
