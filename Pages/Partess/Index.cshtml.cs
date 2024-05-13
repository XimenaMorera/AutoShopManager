using AutoShopManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Partess
{
    public class IndexModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public IndexModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        public IList<Partes> Partess { get; set; } = default;

        public async Task OnGetAsync()
        {
            if (_context.Partess != null)
            {
                Partess = await _context.Partess.ToListAsync();
            }
        }
    }
}
