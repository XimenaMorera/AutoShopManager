using AutoShopManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Reparaciones
{
    public class IndexModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public IndexModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        public IList<Reparacion> Reparaciones { get; set; } = default;

        public async Task OnGetAsync()
        {
            if (_context.Reparaciones != null)
            {
				Reparaciones = await _context.Reparaciones.ToListAsync();
            }
        }
    }
}
