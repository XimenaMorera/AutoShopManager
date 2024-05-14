using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Vehiculos
{
    public class DeleteModel : PageModel
    {
		private readonly AutoShopManagerContext _context;
		public DeleteModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]

		public Vehiculo Vehiculo { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Vehiculos == null)
			{
				return NotFound();
			}
			var vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(m => m.Id == id);
			if (vehiculo == null)
			{
				return NotFound();
			}
			else
			{
				Vehiculo = vehiculo;
				_context.Vehiculos.Remove(vehiculo);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}
	}
}
