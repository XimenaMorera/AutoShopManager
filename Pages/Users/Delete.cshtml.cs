using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Users
{
    public class DeleteModel : PageModel
    {
		private readonly AutoShopManagerContext _context;
		public DeleteModel(AutoShopManagerContext context)
		{
			_context = context;
		}
		[BindProperty]

		public User User { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Users == null)
			{
				return NotFound();
			}
			var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			else
			{
				User = user;
				_context.Users.Remove(user);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}

	}
}
