using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public IndexModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        public IList<User> Users { get; set; } = default;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                Users = await _context.Users.ToListAsync();
            }
        }
    }
}
