using BioLab_Diagnostics.Data;
using Microsoft.AspNetCore.Mvc;

namespace BioLab_Diagnostics.Controllers
{
	public class UsuarioController : Controller
	{
        public IActionResult Index(Usuario usuario)
        {
            ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
            ViewData["Imagen"] = usuario.Imagen;
            return View();
        }
        //public IActionResult Index(Usuario usuario)
        //{
        //	ViewBag.Nombre = usuario.Nombre;
        //	return View();
        //}
    }
}
