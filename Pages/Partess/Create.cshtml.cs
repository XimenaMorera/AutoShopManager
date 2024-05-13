using AutoShopManager.Data;
using AutoShopManager.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Models;
using Partes = AutoShopManager.Models.Partes;



namespace AutoShopManager.Pages.Partess
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
		public Partes Partes { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Partess == null || Partes == null)
			{
				return Page();
			}
			_context.Partess.Add(Partes);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
