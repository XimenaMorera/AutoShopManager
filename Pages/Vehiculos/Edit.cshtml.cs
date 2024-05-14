using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Vehiculos
{
    public class EditModel : PageModel
    {
		private readonly AutoShopManagerContext _context;

		public EditModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]
		public Vehiculo Vehiculo { get; set; } = default;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Vehiculos == null)
			{
				return NotFound();
			}

			var cliente = await _context.Vehiculos.FirstOrDefaultAsync(m => m.Id == id);
			if (cliente == null)
			{
				return NotFound();
			}
			Vehiculo = Vehiculo;
			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Attach(Vehiculo).State = EntityState.Modified;


			try
			{
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				if (!VehiculoExists(Vehiculo.Id))
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

		private bool VehiculoExists(int id)
		{
			return (_context.Vehiculos?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
