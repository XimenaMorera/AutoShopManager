using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoShopManager.Pages.Clientes
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
		public Cliente Cliente { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Clientes == null || Cliente == null)
			{
				return Page();
			}
			_context.Clientes.Add(Cliente);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}

	}
}
