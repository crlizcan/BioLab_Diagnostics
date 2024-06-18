using BioLab_Diagnostics.Data;
using BioLab_Diagnostics.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BioLab_Diagnostics.Controllers
{
	public class PrincipalController : Controller
	{
        private readonly BioLab_DiagnosticsContext _context;
        private readonly UserManager<Usuario> _userManager;
		public PrincipalController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager)
		{
            _context = context;
            _userManager = userManager;
		}
		public async Task<IActionResult> IndexAsync()
		{
			var usuario = await _userManager.GetUserAsync(User);
            var peticiones = _context.Peticiones
                .Where(p => p.FechaVisita >= DateTime.Now.AddMonths(-12) && p.FechaVisita <= DateTime.Now)
                .OrderBy(p => p.FechaVisita)
                .ToList();

            // Guardo los nombres de los últimos 12 meses
            var meses = new List<string>();

            // Guardo el número de peticiones que se han hecho en los últimos 12 meses
            var numPeticionesPorMes = new List<int>();

            //Guardo los beneficios de cada mes
            var beneficios = new List<decimal>();

            for (int i = 12; i > 0; i--)
            {
                var fecha = DateTime.Now.AddMonths(-i);
                var nombreMes = fecha.ToString("MMM", CultureInfo.CreateSpecificCulture("es-ES")).Substring(0, 1).ToUpper() + fecha.ToString("MMM", CultureInfo.CreateSpecificCulture("es-ES")).Substring(1, 2).ToLower();
                meses.Add(nombreMes);
                var peticionesEnMes = peticiones.Where(p => p.FechaVisita.Month == fecha.Month && p.FechaVisita.Year == fecha.Year);          
                numPeticionesPorMes.Add(peticionesEnMes.Count());
                decimal beneficiosEnMes = 0;
                foreach (var item in peticionesEnMes)
                {
                    beneficiosEnMes = beneficiosEnMes + item.Importe;
                    
                }
                beneficios.Add(beneficiosEnMes);
                 
            }
            var peticionesTotales = _context.Peticiones.ToList();
            var numPeticionesTotales = peticionesTotales.Count();
            var numPeticionesAbiertas = peticionesTotales.Where(p => p.Estado.Equals("S. PRUEBAS") || p.Estado.Equals("PROCESANDO") || p.Estado.Equals("COMPLETADO")).Count();
            //Obtengo las 5 pruebas más solicitadas
            var pruebasMasSolicitadas = _context.PeticionesPruebas.Include(p=> p.IdPruebaNavigation).ToList().GroupBy(p => p.IdPruebaNavigation.Nombre).Select(g => new
            {
				NombrePrueba = g.First().IdPruebaNavigation.Nombre,
				CantidadSolicitudes = g.Count()
            }).OrderByDescending(g => g.CantidadSolicitudes).Take(5).ToList();
            var nombresPruebasMasSolicitadas = pruebasMasSolicitadas.Select(p => p.NombrePrueba);
            var cantPruebasMasSolicitadas = pruebasMasSolicitadas.Select(p => p.CantidadSolicitudes);

			var beneficiosTotales = peticionesTotales.Sum(p => p.Importe);

            var pacientes = _context.Clientes.Count();
            ViewData["numPacientes"] = pacientes;
            ViewData["PeticionesTotales"] = numPeticionesTotales;
            ViewData["PeticionesAbiertas"] = numPeticionesAbiertas;
            ViewData["BeneficiosTotales"] = beneficiosTotales;
            ViewData["Beneficios"] = beneficios;
            ViewData["Ultimos12Meses"] = meses;
            ViewData["PeticionesSolicitadas"] = numPeticionesPorMes;
            ViewData["NombresPruebasMasSolicitadas"] = nombresPruebasMasSolicitadas;
			ViewData["CantPruebasMasSolicitadas"] = cantPruebasMasSolicitadas;
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View("PrincipalIndex");
					
		}

	}
}
