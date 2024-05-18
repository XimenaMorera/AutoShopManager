using AutoShopManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AutoShopManager.Pages.Citas
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public IndexModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        public IList<Cita> Citas { get; set; } = default;

        public async Task OnGetAsync()
        {
            if (_context.Citas != null)
            {
                Citas = await _context.Citas.ToListAsync();
            }
        }
    }
}
