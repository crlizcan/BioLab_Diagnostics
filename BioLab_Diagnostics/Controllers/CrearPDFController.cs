using BioLab_Diagnostics.Data;
using BioLab_Diagnostics.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Rotativa.AspNetCore;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System;

namespace BioLab_Diagnostics.Controllers
{
	public class CrearPDFController : Controller
	{
		private readonly BioLab_DiagnosticsContext _context;
		private readonly UserManager<Usuario> _userManager;
		private readonly GmailEmailSender _emailSender;

		public CrearPDFController(BioLab_DiagnosticsContext context, UserManager<Usuario> userManager, GmailEmailSender emailSender)
		{
			_context = context;
			_userManager = userManager;
			_emailSender = emailSender;
		}

		public async Task<IActionResult> IndexAsync(int idPeticion)
		{
			var peticionesPruebas = _context.PeticionesPruebas.Include(o => o.IdPeticionNavigation).Include(v => v.IdPruebaNavigation).Include(vr => vr.IdPruebaNavigation.ValoresReferencia).Where(p => p.IdPeticion == idPeticion).ToList();
			var peticion = _context.Peticiones.Include(p => p.DniClienteNavigation).Where(p => p.IdPeticion == idPeticion).FirstOrDefault();
			var email = peticion.DniClienteNavigation.Email;
			var nombre = peticion.DniClienteNavigation.Nombre + " " + peticion.DniClienteNavigation.Apellidos;

			// Generar el PDF
			var informe = new ViewAsPdf("Index", peticionesPruebas)
			{
				PageSize = Rotativa.AspNetCore.Options.Size.A4,
				PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
				FileName = "Informe de Resultados - BioLab Diagnostics.pdf"
			};

			// Generar el PDF en forma de bytes asincrónicamente
			var pdfBytes = await informe.BuildFile(ControllerContext);

			// Crear el objeto Attachment con los bytes del PDF
			var attachment = new Attachment(new MemoryStream(pdfBytes), "Informe de Resultados - BioLab Diagnostics.pdf", MediaTypeNames.Application.Pdf);

			// Enviar el correo electrónico con el archivo adjunto
			_emailSender.SendMail(
				email,
				"Informe de resultados - BioLab Diagnostics",
				$"Estimado {nombre},<br><br>Nos complace informarle que los resultados de las pruebas clínicas que usted se realizó recientemente en nuestro laboratorio están disponibles. <br><br>Este informe ha sido generado por nuestro equipo de especialistas altamente capacitados. Reconocemos la importancia de estos resultados para usted y hemos seguido rigurosos procedimientos para garantizar su precisión y confidencialidad.<br><br>Para acceder a sus resultados, descargue el adjunto asociado a este correo. <br><br>Atentamente,<br>El equipo de BioLab Diagnostics.",
				attachment
			);
			

			// Actualizar el estado de la petición y redirigir
			peticion.Estado = "ENVIADO";
			peticion.FechaInforme = DateTime.Now;
            ViewData["Estado"] = peticion.Estado;
			_context.Peticiones.Update(peticion);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index", "Peticiones");
		}

        public IActionResult GenerarPDF(int idPeticion)
        {
            var peticionesPruebas = _context.PeticionesPruebas
                .Include(o => o.IdPeticionNavigation)
                .Include(v => v.IdPruebaNavigation)
                .Include(vr => vr.IdPruebaNavigation.ValoresReferencia)
                .Where(p => p.IdPeticion == idPeticion)
                .ToList();

            var informe = new ViewAsPdf("Index", peticionesPruebas)
            {
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                FileName = "Informe de Resultados - BioLab Diagnostics.pdf"
            };

            return informe;
        }
    }
}
