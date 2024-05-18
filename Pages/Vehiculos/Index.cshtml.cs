using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Vehiculos
{
	[Authorize]
    public class IndexModel : PageModel
    {
		private readonly AutoShopManagerContext _context;

		public IndexModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		public IList<Vehiculo> Vehiculos { get; set; } = default;

		public async Task OnGetAsync()
		{
			if (_context.Vehiculos != null)
			{
				Vehiculos = await _context.Vehiculos.ToListAsync();
			}
		}
	}
}
