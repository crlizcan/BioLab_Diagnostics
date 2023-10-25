using BioLab_Diagnostics.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BioLab_Diagnostics
{
	public static class UtilidadesBioLab
	{
		public static string ObtenerDatosUsuario(Usuario usuario)
		{
			string nombreApellido = null;
			if(usuario != null) {
				string[] partesApellido = usuario.Apellidos.Split(" ");
				if (usuario.Nombre.Contains(" "))
				{
					string[] partesNombre = usuario.Nombre.Split(" ");
					nombreApellido = partesNombre[0] + " " + partesApellido[0];
				}
				else
				{
					nombreApellido = usuario.Nombre + " " + partesApellido[0];
				}

				return nombreApellido;
            }
			return null;
		}
	}
}
