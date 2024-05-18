using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Partes
{
    public class DeleteModel : PageModel
    {
		private readonly AutoShopManagerContext _context;
		public DeleteModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]

		public Parte Parte { get; set; } = default!;

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
			else
			{
				Parte = parte;
				_context.Partes.Remove(parte);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}
	}
}
