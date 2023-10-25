using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BioLab_Diagnostics.Models;
using BioLab_Diagnostics.Data;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Internal;

namespace BioLab_Diagnostics.Controllers
{
	public class PeticionesController : Controller
	{
		private readonly BioLab_DiagnosticsContext _context;
		private readonly UserManager<Usuario> _userManager;

		public PeticionesController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		// GET: Peticiones
		public async Task<IActionResult> Index()
		{
			var bioLab_DiagnosticsContext = _context.Peticiones.Include(p => p.DniClienteNavigation);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Petición";
			return View(await bioLab_DiagnosticsContext.ToListAsync());
		}

		// GET: Peticiones/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var peticiones = await _context.Peticiones
				.Include(p => p.DniClienteNavigation)
				.FirstOrDefaultAsync(m => m.IdPeticion == id);
			if (peticiones == null)
			{
				return NotFound();
			}
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Petición";
			return View(peticiones);
		}

		//Busca si el DNI del paciente proporcionado existe en la base de datos
		[HttpPost]
		public async Task<ActionResult> BuscarDniPacienteAsync(string Dni)
		{
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			if (string.IsNullOrWhiteSpace(Dni))
			{
				ModelState.AddModelError("Dni", "El campo DNI está vacío. Por favor, rellene el campo para poder realizar la búsqueda.");
				return View("PeticionCliente");
			}
			else
			{
				var paciente = _context.Clientes.FirstOrDefault(m => m.Dni == Dni);
				if (paciente != null)
				{
					//¿Cómo mostrar el mensaje de que se ha encontrado?
					return View("PeticionCliente", paciente);
				}
				else
				{
					ModelState.AddModelError("Dni", "El DNI no se encuentra en la base de datos. Por favor, rellene todos los campos para añadir al nuevo paciente.");
					return View("PeticionCliente");
				}
			}
		}

		// GET: Peticiones/Create
		public async Task<IActionResult> CreateAsync()
		{
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View();
		}

		// POST: Peticiones/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Clientes peticionCliente)
		{
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			if (ModelState.IsValid)
			{
				var paciente = _context.Clientes.FirstOrDefault(m => m.Dni == peticionCliente.Dni);
				Peticiones peticion = new Peticiones();
				peticion.FechaVisita = DateTime.Now;
				peticion.FechaInforme = null;
				peticion.Importe = 0;
				peticion.Estado = "S. PRUEBAS";
				ViewData["Estado"] = peticion.Estado;
				// Si el paciente existe, sólo se crea la petición; si no existe, se crea el paciente y la petición
				if (paciente != null)
				{
					//Creo la petición
					peticion.DniCliente = paciente.Dni;
					_context.Add(peticion);
					await _context.SaveChangesAsync();
					var idPeticion = _context.Peticiones.Where(pr => pr.DniCliente == peticion.DniCliente && pr.FechaVisita == peticion.FechaVisita && pr.Importe == peticion.Importe).Select(i => i.IdPeticion).FirstOrDefault();
					return RedirectToAction("PeticionPruebas", "Peticiones", new { idPeticion = idPeticion });
				}
				else
				{
					//Creo el paciente y la petición
					peticion.DniCliente = peticionCliente.Dni;
					_context.Clientes.Add(peticionCliente);
					await _context.SaveChangesAsync();
					_context.Add(peticion);
					await _context.SaveChangesAsync();
					var idPeticion = _context.Peticiones.Where(pr => pr.DniCliente == peticion.DniCliente && pr.FechaVisita == peticion.FechaVisita && pr.Importe == peticion.Importe).Select(i => i.IdPeticion).FirstOrDefault().ToString();
					return RedirectToAction("PeticionPruebas", "Peticiones", new { idPeticion = idPeticion });
				}
			}
			return View("PeticionCliente");
		}

		// GET: Peticiones/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var peticiones = await _context.Peticiones.FindAsync(id);
			if (peticiones == null)
			{
				return NotFound();
			}
			ViewData["DniCliente"] = new SelectList(_context.Clientes, "Dni", "Dni", peticiones.DniCliente);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Petición";
			return View(peticiones);
		}

		// POST: Peticiones/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("IdPeticion,DniCliente,FechaVisita,FechaInforme,Importe,Estado")] Peticiones peticiones)
		{
			if (id != peticiones.IdPeticion)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(peticiones);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!PeticionesExists(peticiones.IdPeticion))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["DniCliente"] = new SelectList(_context.Clientes, "Dni", "Dni", peticiones.DniCliente);
			return View(peticiones);
		}

		// GET: Peticiones/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var peticiones = await _context.Peticiones
				.Include(p => p.DniClienteNavigation)
				.FirstOrDefaultAsync(m => m.IdPeticion == id);
			if (peticiones == null)
			{
				return NotFound();
			}
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Petición";
			return View(peticiones);
		}

		// POST: Peticiones/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var peticiones = await _context.Peticiones.FindAsync(id);
			var peticionPruebas = _context.PeticionesPruebas.Where(p => p.IdPeticion == peticiones.IdPeticion).ToList();
			foreach (var item in peticionPruebas)
			{
				_context.PeticionesPruebas.Remove(item);
				await _context.SaveChangesAsync();
			}
			_context.Peticiones.Remove(peticiones);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool PeticionesExists(int id)
		{
			return _context.Peticiones.Any(e => e.IdPeticion == id);
		}
		public async Task<IActionResult> PeticionPruebas(int idPeticion)
		{
			var bioLab_DiagnosticsContext = _context.Pruebas.Include(c => c.ValoresReferencia).Include(p => p.IdDepartamentoNavigation);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["idPeticion"] = idPeticion;
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View(await bioLab_DiagnosticsContext.ToListAsync());
		}
		public async Task<IActionResult> PeticionCliente()
		{
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View();
		}

		//Guarda las pruebas seleccionadas en la petición
		[HttpPost]
		public async Task<ActionResult> GuardarSeleccionadosAsync(string idPeticion, string idsSeleccionados)
		{
			if (!string.IsNullOrEmpty(idsSeleccionados))
			{

				//Guardo los ids de las pruebas seleccionadas
				var ids = idsSeleccionados.Split(',').Select(int.Parse).ToList();
				//Guardo cada prueba seleccionada al crear la petición
				PeticionesPruebas peticionPruebas;
				decimal importe = 0;
				foreach (var item in ids)
				{
					peticionPruebas = new PeticionesPruebas();
					peticionPruebas.IdPeticion = Convert.ToInt32(idPeticion);
					peticionPruebas.IdPrueba = item;
					peticionPruebas.Resultado = null;
					_context.Add(peticionPruebas);
					await _context.SaveChangesAsync();
					//Sumo el importe de todas las pruebas seleccionadas
					var prueba = _context.Pruebas.Where(pr => pr.IdPrueba == item).FirstOrDefault();
					importe = importe + prueba.Precio;
				}
				//Actualizo el importe total de la petición
				var peticion = _context.Peticiones.Where(p => p.IdPeticion == Convert.ToInt32(idPeticion)).FirstOrDefault();
				peticion.Importe = importe;
				//Actualizo el estado de la petición (de "S. PRUEBAS" a "PROCESANDO")
				peticion.Estado = "PROCESANDO";
				ViewData["Estado"] = peticion.Estado;
				_context.Peticiones.Update(peticion);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index", "Peticiones");
			}
			// Manejo el caso cuando no se seleccionó ningún ID
			return RedirectToAction("Index", "Peticiones");
		}

		//GET: Vista PeticionResultados
		public async Task<IActionResult> PeticionResultados(int id)
		{
			var peticion = await _context.Peticiones.FindAsync(id);
			var paciente = _context.Peticiones.Include(p => p.DniClienteNavigation).Where(pp => pp.IdPeticion == id).FirstOrDefault();
			//var peticionesPruebas = _context.PeticionesPruebas.Where(p => p.IdPeticion == peticion.IdPeticion);
			var bioLab_DiagnosticsContext = _context.PeticionesPruebas.Include(p => p.IdPeticionNavigation).Include(pp => pp.IdPeticionNavigation.DniClienteNavigation).Include(m => m.IdPruebaNavigation).Include(mm => mm.IdPruebaNavigation.ValoresReferencia).Include(d => d.IdPruebaNavigation.IdDepartamentoNavigation).Where(p => p.IdPeticion == peticion.IdPeticion);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			//Si la petición tiene todos los análisis completados, se muestra la opción de enviar los resultados al paciente por correo electrónico en formato PDF
			ViewData["Resultados"] = "No completados";
			var resultados = _context.PeticionesPruebas.Where(p => p.IdPeticion == peticion.IdPeticion).Select(i => i.Resultado).ToList();
			if (!resultados.Contains(null))
			{
				ViewData["Resultados"] = "Completados";
				ViewData["idPeticion"] = peticion.IdPeticion;
			}
			ViewData["NPeticion"] = peticion.IdPeticion;
			ViewData["FechaVisita"] = peticion.FechaVisita.ToString("dd/MM/yyyy");
			ViewData["NombreCompleto"] = (paciente.DniClienteNavigation.Nombre + " " + paciente.DniClienteNavigation.Apellidos).ToUpper();
			ViewData["Estado"] = peticion.Estado.ToUpper();
			return View(await bioLab_DiagnosticsContext.ToListAsync());
		}

		//Post: PeticionResultados. Guarda los resultados de las pruebas realizadas
		[HttpPost]
		public async Task<ActionResult> GuardarResultados(IEnumerable<PeticionesPruebas> peticionesPruebas)
		{
			foreach (var item in peticionesPruebas)
			{
				if (item.Resultado != null)
				{
					//Actualizo el resultado de la prueba
					_context.PeticionesPruebas.Update(item);
					await _context.SaveChangesAsync();
					//Si la petición tiene todos los análisis completados, se cambia el estado (de "PROCESANDO" a "COMPLETADO")
					var resultados = _context.PeticionesPruebas.Where(p => p.IdPeticion == item.IdPeticion).Select(i => i.Resultado).ToList();
					if (!resultados.Contains(null))
					{
						var peticion = _context.Peticiones.Where(p => p.IdPeticion == item.IdPeticion).FirstOrDefault();
						peticion.Estado = "COMPLETADO";
						ViewData["Estado"] = peticion.Estado;
						_context.Peticiones.Update(peticion);
						await _context.SaveChangesAsync();
					}
				}
			}
			return RedirectToAction("Index", "Peticiones");
		}

		// GET: Editar resultados
		[HttpGet]
		public async Task<IActionResult> EditarResultados(int id)
		{
			var peticion = await _context.Peticiones.FindAsync(id);
			var peticionesPruebas = _context.PeticionesPruebas.Include(p => p.IdPeticionNavigation).Include(pp => pp.IdPeticionNavigation.DniClienteNavigation).Include(m => m.IdPruebaNavigation).Include(mm => mm.IdPruebaNavigation.ValoresReferencia).Include(d => d.IdPruebaNavigation.IdDepartamentoNavigation).Where(p => p.IdPeticion == peticion.IdPeticion).ToList();
			if (peticion == null)
			{
				return NotFound();
			}
			//ViewData["DniCliente"] = new SelectList(_context.Clientes, "Dni", "Dni", peticiones.DniCliente);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Petición";
			ViewData["NPeticion"] = peticion.IdPeticion;
			ViewData["FechaVisita"] = peticion.FechaVisita.ToString("dd/MM/yyyy");
			ViewData["NombreCompleto"] = (peticion.DniClienteNavigation.Nombre + " " + peticion.DniClienteNavigation.Apellidos).ToUpper();
			ViewData["Estado"] = peticion.Estado.ToUpper();
			return View(peticionesPruebas);
		}

		// POST: Editar Resultados
		[HttpPost]
		public async Task<IActionResult> EditarResultados(IEnumerable<PeticionesPruebas> peticionesPruebas)
		{
			foreach (var item in peticionesPruebas)
			{
				if (item.Resultado != null)
				{
					//Actualizo el resultado de la prueba
					_context.PeticionesPruebas.Update(item);
					await _context.SaveChangesAsync();
				}
			}
			//Si la petición tiene todos los análisis completados, se cambia el estado (de "PROCESANDO" a "COMPLETADO")
			var resultados = _context.PeticionesPruebas.Where(p => p.IdPeticion == peticionesPruebas.FirstOrDefault().IdPeticion).Select(i => i.Resultado).ToList();
			if (!resultados.Contains(null))
			{
				var peticion = _context.Peticiones.Where(p => p.IdPeticion == peticionesPruebas.FirstOrDefault().IdPeticion).FirstOrDefault();
				peticion.Estado = "COMPLETADO";
				ViewData["Estado"] = peticion.Estado;
				_context.Peticiones.Update(peticion);
				await _context.SaveChangesAsync();
			}
			return RedirectToAction("PeticionResultados", "Peticiones", new { id = peticionesPruebas.FirstOrDefault().IdPeticion });
		}
	}
}
