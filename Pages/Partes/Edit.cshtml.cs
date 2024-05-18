using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Partes
{
    public class EditModel : PageModel
    {
		private readonly AutoShopManagerContext _context;

		public EditModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]
		public Parte Parte { get; set; } = default;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Partes == null)
			{
				return NotFound();
			}

			var parte = await _context.Partes.FirstOrDefaultAsync(m => m.Id == id);
			if (parte == null)
			{
				return NotFound();
			}
			Parte = parte;
			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Attach(Parte).State = EntityState.Modified;


			try
			{
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				if (!ParteExists(Parte.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return RedirectToPage("./Index");
		}

		private bool ParteExists(int id)
		{
			return (_context.Partes?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
