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
    public class DepartamentosController : Controller
    {
        private readonly BioLab_DiagnosticsContext _context;
		private readonly UserManager<Usuario> _userManager;

		public DepartamentosController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager)
        {
            _context = context;
			_userManager = userManager;
		}

        // GET: Departamentos
        public async Task<IActionResult> Index()
        {
            var usuario = await _userManager.GetUserAsync(User);
            return View(await _context.Departamentos.ToListAsync());
        }

        // GET: Departamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos
                .FirstOrDefaultAsync(m => m.IdDepartamento == id);
            if (departamentos == null)
            {
                return NotFound();
            }

            return View(departamentos);
        }

        // GET: Departamentos/Create
        public async Task<IActionResult> CreateAsync()
        {
            var usuario = await _userManager.GetUserAsync(User);
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            return View();
        }

        // POST: Departamentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDepartamento,Nombre,Descripcion")] Departamentos departamentos)
        {
            var usuario = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                _context.Add(departamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            return View(departamentos);
        }

        // GET: Departamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos.FindAsync(id);
            if (departamentos == null)
            {
                return NotFound();
            }
            return View(departamentos);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDepartamento,Nombre,Descripcion")] Departamentos departamentos)
        {
            if (id != departamentos.IdDepartamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentosExists(departamentos.IdDepartamento))
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
            return View(departamentos);
        }

        // GET: Departamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos
                .FirstOrDefaultAsync(m => m.IdDepartamento == id);
            if (departamentos == null)
            {
                return NotFound();
            }

            return View(departamentos);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departamentos = await _context.Departamentos.FindAsync(id);
            _context.Departamentos.Remove(departamentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentosExists(int id)
        {
            return _context.Departamentos.Any(e => e.IdDepartamento == id);
        }
    }
}
