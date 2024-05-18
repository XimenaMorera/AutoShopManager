using AutoShopManager.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace AutoShopManager.Pages.Account
{
    public class LoginModel : PageModel
    {
       

        [BindProperty]
        public User User { get; set; }

       
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            // Busca un usuario con el correo electr�nico especificado
         //   var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == User.Email);

            if (User.Email == "correo@gmail.com" && User.Password == "12345")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email,User.Email),
                };
                //asociando los claims creados al nombre de una cookie
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                //se agrega la identidad crada al ClaimPrincipal de la apliacacion
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                //registro exitoso y se crea la cookie en el navegador
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                return RedirectToPage("/index");
            }
            ModelState.AddModelError(string.Empty, "Correo electr�nico o contrase�a incorrectos.");
            return Page();
        }
    }
}
