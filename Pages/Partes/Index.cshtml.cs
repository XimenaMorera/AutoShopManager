using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Partes
{
    public class IndexModel : PageModel
    {
		private readonly AutoShopManagerContext _context;

		public IndexModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		public IList<Parte> Partes { get; set; } = default;

		public async Task OnGetAsync()
		{
			if (_context.Partes != null)
			{
				Partes = await _context.Partes.ToListAsync();
			}
		}
	}
}
