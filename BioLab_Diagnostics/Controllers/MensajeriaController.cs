using Microsoft.AspNetCore.Mvc;
using BioLab_Diagnostics.Data;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BioLab_Diagnostics.Controllers
{
	public class MensajeriaController : Controller
	{
		private readonly UserManager<Usuario> _userManager;

		//No funciona si le doy al Nombre, no me lleva a la información de usuario
		//Esto le he añadido
		public MensajeriaController(UserManager<Usuario> userManager)
		{
			_userManager = userManager;
		}
		public async Task<IActionResult> IndexAsync()
		{
			var usuario = await _userManager.GetUserAsync(User);
			ViewData["NombreApellido"] = UtilidadesBioLab.ObtenerDatosUsuario(usuario);
			ViewData["Imagen"] = usuario.Imagen;
			return View("MensajeriaIndex");
		}
		//public IActionResult Index()
		//{
		//	return View("MensajeriaIndex");
		//}
	}
}
