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

namespace BioLab_Diagnostics.Controllers
{
    public class ClientesController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly BioLab_DiagnosticsContext _context;

        public ClientesController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            ViewData["Crear"] = "Paciente";
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.Include(p => p.Peticiones).FirstOrDefaultAsync(m => m.Dni == id);
            if (clientes == null)
            {
                return NotFound();
            }
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            ViewData["Crear"] = "Paciente";
            return View(clientes);
        }

        // GET: Clientes/Create
        public async Task<IActionResult> CreateAsync()
        {
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Dni,Nombre,Apellidos,FechaNacimiento,Sexo,Telefono,Email")] Clientes clientes)
        {
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            if (_context.Clientes.Any(m => m.Dni == clientes.Dni) == true)
            {
                ModelState.AddModelError("DNI", "El DNI proporcionado ya está registrado en el sistema.");
            }
            else if (clientes.Dni != null && clientes.Dni.Length != 9)
            {
                ModelState.AddModelError("DNI", "El DNI debe contener 9 caracteres.");
            }
            else if (ModelState.IsValid)
            {
                _context.Add(clientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            //ViewData["Crear"] = "Paciente";
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Dni,Nombre,Apellidos,FechaNacimiento,Sexo,Telefono,Email")] Clientes clientes)
        {
            if (id != clientes.Dni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesExists(clientes.Dni))
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
            return View(clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Dni == id);
            if (clientes == null)
            {
                return NotFound();
            }
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            ViewData["Crear"] = "Paciente";
            return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            var peticiones = _context.Peticiones.Where(p => p.DniCliente == clientes.Dni).ToList();
            if(peticiones!=null)
            {
                foreach (var peticion in peticiones)
                {
                    var peticionesPruebas = _context.PeticionesPruebas.Where(x => x.IdPeticion == peticion.IdPeticion);
                    if (peticionesPruebas != null)
                    {
                        _context.PeticionesPruebas.RemoveRange(peticionesPruebas);
                    }
                }
                _context.Peticiones.RemoveRange(peticiones);
            }
            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesExists(string id)
        {
            return _context.Clientes.Any(e => e.Dni == id);
        }
    }
}
