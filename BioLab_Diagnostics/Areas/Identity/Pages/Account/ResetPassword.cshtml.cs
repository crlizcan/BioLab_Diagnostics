using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using BioLab_Diagnostics.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace BioLab_Diagnostics.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<Usuario> _userManager;

        public ResetPasswordModel(UserManager<Usuario> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "El campo email es obligatorio.")]
            [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
            public string Email { get; set; }

            [Display(Name ="Nueva contraseña")]
            [Required(ErrorMessage = "El campo Nueva Contraseña es obligatorio.")]
            [StringLength(100, ErrorMessage = "La contraseña debe tener una longitud mínima de 6 y máxima de 100 caracteres.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

			[Required(ErrorMessage = "El campo Confirmar Contraseña es obligatorio.")]
			[DataType(DataType.Password)]
            [Display(Name = "Confirmar nueva contraseña")]
            [Compare("Password", ErrorMessage = "La nueva contraseña y la confirmación de nueva contraseña no coinciden.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            if (code == null)
            {
                return BadRequest("A code must be supplied for password reset.");
            }
            else
            {
                Input = new InputModel
                {
                    Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();
        }
    }
}
