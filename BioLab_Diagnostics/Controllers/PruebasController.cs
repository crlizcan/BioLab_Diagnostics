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
using System.Globalization;
using NodaTime;
using System.Drawing;

namespace BioLab_Diagnostics.Controllers
{
    public class PruebasController : Controller
    {
        private readonly BioLab_DiagnosticsContext _context;
		private readonly UserManager<Usuario> _userManager;

		public PruebasController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager)
        {
            _context = context;
			_userManager = userManager;
		}

        // GET: Pruebas
        public async Task<IActionResult> Index()
        {
            var bioLab_DiagnosticsContext = _context.Pruebas.Include(c => c.ValoresReferencia).Include(p => p.IdDepartamentoNavigation);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Prueba";
			return View(await bioLab_DiagnosticsContext.ToListAsync());
        }

        // GET: Pruebas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var pruebas = await _context.Pruebas
                .Include(p => p.IdDepartamentoNavigation).Include(c => c.ValoresReferencia)
                .FirstOrDefaultAsync(m => m.IdPrueba == id);
            if (pruebas == null)
            {
                return NotFound();
            }

			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Prueba";
			return View(pruebas);
        }

		// GET: Pruebas/Create
		public async Task<IActionResult> CreateAsync()
		{
            var departamentos = _context.Departamentos.OrderBy(m => m.Nombre);
            ViewData["IdDepartamento"] = new SelectList(departamentos, "IdDepartamento", "Nombre");
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View();
        }

		// POST: Pruebas/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(PruebasValoresReferenciaViewModel vm)
		{
			if (ModelState.IsValid)
			{
                Pruebas prueba = new Pruebas();
                prueba.Nombre = vm.pruebas.Nombre;
                prueba.Precio = vm.pruebas.Precio;
                prueba.Descripcion = vm.pruebas.Descripcion;
                prueba.IdDepartamento = vm.pruebas.IdDepartamento;
                prueba.Unidades = vm.pruebas.Unidades;
                prueba.EsActivo = true;
				_context.Add(prueba);
                ValoresReferencia vr;
				if (vm.Vr_unico.Equals("Si")) {
                    if (!string.IsNullOrWhiteSpace(vm.ValorReferenciaMujer) && !string.IsNullOrWhiteSpace(vm.ValorReferenciaHombre) || !string.IsNullOrWhiteSpace(vm.ValorReferenciaInicioMujer) && !string.IsNullOrWhiteSpace(vm.ValorReferenciaFinMujer) && !string.IsNullOrWhiteSpace(vm.ValorReferenciaInicioHombre) && !string.IsNullOrWhiteSpace(vm.ValorReferenciaFinHombre)) {
						await _context.SaveChangesAsync();
						var idPruebaDb = _context.Pruebas.Where(pr => pr.Nombre == prueba.Nombre && pr.Descripcion == prueba.Descripcion && pr.Precio == prueba.Precio && pr.IdDepartamento == prueba.IdDepartamento && pr.Unidades == prueba.Unidades).Select(i => i.IdPrueba).FirstOrDefault();
						//Mujer
						vr = new ValoresReferencia();
						vr.IdPrueba = idPruebaDb;
                        if (vm.Operacion.Equals("Intervalo"))
                        {
							vr.ValorReferencia = vm.ValorReferenciaInicioMujer + "-" + vm.ValorReferenciaFinMujer;
						} 
                        else if (vm.Operacion.Equals("="))
                        {
							vr.ValorReferencia = vm.ValorReferenciaMujer.ToUpper();
						}
                        else
                        {
							vr.ValorReferencia = vm.Operacion + vm.ValorReferenciaMujer;				
						}
						vr.Sexo = "M";
						_context.Add(vr);
						//Hombre
						vr = new ValoresReferencia();
                        vr.IdPrueba = idPruebaDb;
						if (vm.Operacion.Equals("Intervalo"))
						{
							vr.ValorReferencia = vm.ValorReferenciaInicioHombre + "-" + vm.ValorReferenciaFinHombre;
						}
						else if (vm.Operacion.Equals("="))
						{
							vr.ValorReferencia = vm.ValorReferenciaHombre.ToUpper();
						}
						else
						{
							vr.ValorReferencia = vm.Operacion + vm.ValorReferenciaHombre;

						}
						
						vr.Sexo = "H";
						_context.Add(vr);
						await _context.SaveChangesAsync();
						return RedirectToAction(nameof(Index));
					} else if (string.IsNullOrWhiteSpace(vm.ValorReferenciaHombre))
					{
						ModelState.AddModelError("ValorReferenciaHombre", "Rellene el valor de referencia del hombre");
					} else
                    {
						ModelState.AddModelError("ValorReferenciaMujer", "Rellene el valor de referencia de la mujer");
					}
                }
                else {
                    if(!string.IsNullOrWhiteSpace(vm.ValorReferencia) || !string.IsNullOrWhiteSpace(vm.ValorReferenciaInicio) && !string.IsNullOrWhiteSpace(vm.ValorReferenciaFin))
                    {
						await _context.SaveChangesAsync();
						var idPruebaDb = _context.Pruebas.Where(pr => pr.Nombre == prueba.Nombre && pr.Descripcion == prueba.Descripcion && pr.Precio == prueba.Precio && pr.IdDepartamento == prueba.IdDepartamento && pr.Unidades == prueba.Unidades).Select(i => i.IdPrueba).FirstOrDefault();
						//Valor único
						vr = new ValoresReferencia();
						vr.IdPrueba = idPruebaDb;
						if (vm.Operacion.Equals("Intervalo"))
						{
							vr.ValorReferencia = vm.ValorReferenciaInicio + "-" + vm.ValorReferenciaFin;
						}
						else if (vm.Operacion.Equals("="))
						{
							vr.ValorReferencia = vm.ValorReferencia.ToUpper();
						}
						else
						{
							vr.ValorReferencia = vm.Operacion + vm.ValorReferencia;
						}
						vr.Sexo = null;
						_context.ValoresReferencia.Add(vr);
						await _context.SaveChangesAsync();
						return RedirectToAction(nameof(Index));
					}
                    else
                    {
						ModelState.AddModelError("ValorReferencia", "Rellene el valor de referencia de la mujer");
					}
				}
			}
			ViewData["IdDepartamento"] = new SelectList(_context.Departamentos, "IdDepartamento", "Nombre", vm.pruebas.IdDepartamento);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View(vm);
		}

		// GET: Pruebas/Edit/5
		public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pruebas = await _context.Pruebas.FindAsync(id);
            if (pruebas == null)
            {
                return NotFound();
            }
            var valoresReferencia = await _context.ValoresReferencia.Where(vr => vr.IdPrueba == id).ToListAsync();
			var pruebasValoresReferenciaViewModel = new PruebasValoresReferenciaViewModel { };
			if (valoresReferencia.Count() > 1)
            {
				pruebasValoresReferenciaViewModel.Vr_unico = "Si";
                //Intervalo
                if (valoresReferencia[0].ValorReferencia.Contains("-"))
                {
                    String[] intervalo = null;

					pruebasValoresReferenciaViewModel.Operacion = "Intervalo";
                    for(int i = 0; i<valoresReferencia.Count(); i++)
                    {
                        if (valoresReferencia[i].Sexo.Equals("M")){
							intervalo = valoresReferencia[i].ValorReferencia.Split("-");
							double limiteInferior = double.Parse(intervalo[0], CultureInfo.InvariantCulture);
							double limiteSuperior = double.Parse(intervalo[1], CultureInfo.InvariantCulture);
							pruebasValoresReferenciaViewModel.ValorReferenciaInicioMujer = limiteInferior.ToString();
							pruebasValoresReferenciaViewModel.ValorReferenciaFinMujer = limiteSuperior.ToString();
						} else
                        {
							intervalo = valoresReferencia[i].ValorReferencia.Split("-");
							double limiteInferior = double.Parse(intervalo[0], CultureInfo.InvariantCulture);
							double limiteSuperior = double.Parse(intervalo[1], CultureInfo.InvariantCulture);
							pruebasValoresReferenciaViewModel.ValorReferenciaInicioHombre = limiteInferior.ToString();
							pruebasValoresReferenciaViewModel.ValorReferenciaFinHombre = limiteSuperior.ToString();
						}
                    }

				} else if (valoresReferencia[0].ValorReferencia.Contains("<") || valoresReferencia[0].ValorReferencia.Contains(">") || valoresReferencia[0].ValorReferencia.Contains("<=") || valoresReferencia[0].ValorReferencia.Contains(">="))
                {
					if (valoresReferencia[0].ValorReferencia.Contains("<="))
					{
						pruebasValoresReferenciaViewModel.Operacion = "<=";
						for (int i = 0; i < valoresReferencia.Count(); i++)
						{
							if (valoresReferencia[i].Sexo.Equals("M"))
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace("<=", "");
							}
							else
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace("<=", "");
							}
						}
					}
					else if (valoresReferencia[0].ValorReferencia.Contains(">="))
					{
						pruebasValoresReferenciaViewModel.Operacion = ">=";
						for (int i = 0; i < valoresReferencia.Count(); i++)
						{
							if (valoresReferencia[i].Sexo.Equals("M"))
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace(">=", "");
							}
							else
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace(">=", "");
							}
						}
					}
					else if (valoresReferencia[0].ValorReferencia.Contains("<") && !valoresReferencia[0].ValorReferencia.Contains("="))
					{
						pruebasValoresReferenciaViewModel.Operacion = "<";
						for (int i = 0; i < valoresReferencia.Count(); i++)
						{
							if (valoresReferencia[i].Sexo.Equals("M"))
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace("<", "");
							}
							else
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace("<", "");
							}
						}
					}
					else if (valoresReferencia[0].ValorReferencia.Contains(">") && !valoresReferencia[0].ValorReferencia.Contains("="))
					{
						pruebasValoresReferenciaViewModel.Operacion = ">";
						for (int i = 0; i < valoresReferencia.Count(); i++)
						{
							if (valoresReferencia[i].Sexo.Equals("M"))
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace(">", "");
							}
							else
							{
								pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.Replace(">", "");
							}
						}
					}
				} else //Igual
                {
                    pruebasValoresReferenciaViewModel.Operacion = "=";
					for (int i = 0; i < valoresReferencia.Count(); i++)
					{
						if (valoresReferencia[i].Sexo.Equals("M"))
						{
							pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.ToUpper();
						}
						else
						{
							pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[i].ValorReferencia.ToUpper();
						}
					}
				}

			} else
            {
				pruebasValoresReferenciaViewModel.Vr_unico = "No";
                pruebasValoresReferenciaViewModel.Sexo = "";
				//Intervalo
				if (valoresReferencia[0].ValorReferencia.Contains("-"))
				{
					pruebasValoresReferenciaViewModel.Operacion = "Intervalo";
					var intervalo = valoresReferencia[0].ValorReferencia.Split("-");
					double limiteInferior = double.Parse(intervalo[0], CultureInfo.InvariantCulture);
					double limiteSuperior = double.Parse(intervalo[1], CultureInfo.InvariantCulture);
                    pruebasValoresReferenciaViewModel.ValorReferenciaInicio = limiteInferior.ToString();
                    pruebasValoresReferenciaViewModel.ValorReferenciaFin = limiteSuperior.ToString();
				}
				else if (valoresReferencia[0].ValorReferencia.Contains("<") || valoresReferencia[0].ValorReferencia.Contains(">") || valoresReferencia[0].ValorReferencia.Contains("<=") || valoresReferencia[0].ValorReferencia.Contains(">="))
				{
					if (valoresReferencia[0].ValorReferencia.Contains("<="))
					{
						pruebasValoresReferenciaViewModel.Operacion = "<=";
						pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[0].ValorReferencia.Replace("<=", "");
					}
					else if (valoresReferencia[0].ValorReferencia.Contains(">="))
					{
						pruebasValoresReferenciaViewModel.Operacion = ">=";
						pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[0].ValorReferencia.Replace(">=", "");
					}
					else if (valoresReferencia[0].ValorReferencia.Contains("<") && !valoresReferencia[0].ValorReferencia.Contains("="))
					{
						pruebasValoresReferenciaViewModel.Operacion = "<";
						pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[0].ValorReferencia.Replace("<", "");
					}
					else if (valoresReferencia[0].ValorReferencia.Contains(">") && !valoresReferencia[0].ValorReferencia.Contains("="))
					{
						pruebasValoresReferenciaViewModel.Operacion = ">";
						pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[0].ValorReferencia.Replace(">", "");
					}
				}
				else //Igual
				{
					pruebasValoresReferenciaViewModel.Operacion = "=";
					pruebasValoresReferenciaViewModel.ValorReferencia = valoresReferencia[0].ValorReferencia.ToUpper();
				}
			}

			pruebasValoresReferenciaViewModel.pruebas = pruebas;
            ViewData["IdDepartamento"] = new SelectList(_context.Departamentos, "IdDepartamento", "Nombre", pruebas.IdDepartamento);
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View(pruebasValoresReferenciaViewModel);
        }

        // POST: Pruebas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PruebasValoresReferenciaViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //Edito la prueba

                Pruebas prueba = await _context.Pruebas.FirstOrDefaultAsync(v => v.IdPrueba == id);
				prueba.Nombre = vm.pruebas.Nombre;
				prueba.Precio = vm.pruebas.Precio;
				prueba.Descripcion = vm.pruebas.Descripcion;
				prueba.IdDepartamento = vm.pruebas.IdDepartamento;
				_context.Pruebas.Update(prueba);
				await _context.SaveChangesAsync();
                var valoresReferencia = await _context.ValoresReferencia
					.Where(v => v.IdPrueba == id)
					.ToListAsync();
				//Edito los valores de referencia
				if (vm.Vr_unico.Equals("Si"))
				{
                    //Obtengo el IdReferencia, en este caso son dos
                    if (!vm.Operacion.Equals("Intervalo"))
                    {
                        foreach (var valor in valoresReferencia)
                        {
                            if (vm.ValorReferenciaMujer !=null)
                            {
								if (!vm.Operacion.Equals("="))
								{
									valor.ValorReferencia = vm.Operacion + vm.ValorReferenciaMujer;
								} else
								{
                                    valor.ValorReferencia = vm.ValorReferenciaMujer;
                                }
                                _context.ValoresReferencia.Update(valor);
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                if (!vm.Operacion.Equals("="))
                                {
                                    valor.ValorReferencia = vm.Operacion + vm.ValorReferenciaHombre;
								} else
								{
									valor.ValorReferencia = vm.ValorReferenciaHombre;
								}
								_context.ValoresReferencia.Update(valor);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                    else
                    {
                        foreach (var valor in valoresReferencia)
                        {
                            if (vm.ValorReferenciaInicioMujer != null)
                            {
                                valor.ValorReferencia = vm.ValorReferenciaInicioMujer + "-" + vm.ValorReferenciaFinMujer;
                                _context.ValoresReferencia.Update(valor);
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                valor.ValorReferencia = vm.ValorReferenciaInicioHombre + "-" + vm.ValorReferenciaFinHombre;
                                _context.ValoresReferencia.Update(valor);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                } else
				{
                    //Obtengo el IdReferencia, en este caso es uno
                    var idReferencia = prueba.ValoresReferencia.First().IdReferencia;
                    if (!vm.Operacion.Equals("Intervalo"))
                    {
						if (!vm.Operacion.Equals("=")){
                            valoresReferencia[0].ValorReferencia = vm.Operacion + vm.ValorReferencia;
                        } else
						{
                            valoresReferencia[0].ValorReferencia = vm.ValorReferencia;
                        }
                        _context.ValoresReferencia.Update(valoresReferencia[0]);
                    }
                    else
                    {
                        valoresReferencia[0].ValorReferencia = vm.ValorReferenciaInicio + "-" + vm.ValorReferenciaFin;
                        _context.ValoresReferencia.Update(valoresReferencia[0]);
                    }
                    await _context.SaveChangesAsync();
				}
                return RedirectToAction(nameof(Index));
            } else
			{
                ViewData["IdDepartamento"] = new SelectList(_context.Departamentos, "IdDepartamento", "Descripcion", vm.pruebas.IdDepartamento);
                return View(vm);
            }

        }



        // GET: Pruebas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pruebas = await _context.Pruebas
                .Include(p => p.IdDepartamentoNavigation)
                .FirstOrDefaultAsync(m => m.IdPrueba == id);
            if (pruebas == null)
            {
                return NotFound();
            }

			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			ViewData["Crear"] = "Prueba";
			return View(pruebas);
        }

        // POST: Pruebas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
			var prueba = await _context.Pruebas.FindAsync(id);
            prueba.EsActivo = false;
            _context.Pruebas.Update(prueba);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
        }

        private bool PruebasExists(int id)
        {
            return _context.Pruebas.Any(e => e.IdPrueba == id);
        }
    }
}
