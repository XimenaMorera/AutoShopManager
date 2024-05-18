using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Clientes
{
    public class IndexModel : PageModel
    {
		private readonly AutoShopManagerContext _context;

		public IndexModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		public IList<Cliente> Clientes { get; set; } = default;

		public async Task OnGetAsync()
		{
			if (_context.Clientes != null)
			{
				Clientes = await _context.Clientes.ToListAsync();
			}
		}
	}
}
