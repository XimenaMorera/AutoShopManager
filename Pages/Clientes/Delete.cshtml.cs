using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
		private readonly AutoShopManagerContext _context;
		public DeleteModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]

		public Cliente Cliente { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Clientes == null)
			{
				return NotFound();
			}
			var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
			if (cliente == null)
			{
				return NotFound();
			}
			else
			{
				Cliente = cliente;
				_context.Clientes.Remove(cliente);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}
	}
}
