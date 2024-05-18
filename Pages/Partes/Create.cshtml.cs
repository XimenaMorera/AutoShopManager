using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoShopManager.Pages.Partes
{
    public class CreateModel : PageModel
    {
        private readonly AutoShopManagerContext _context;
        public CreateModel(AutoShopManagerContext context)
        {
            //SupermarketContext context = null;
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Parte Parte { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Partes == null || Parte == null)
            {
                return Page();
            }
            _context.Partes.Add(Parte);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
