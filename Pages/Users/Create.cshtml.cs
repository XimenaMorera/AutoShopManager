using AutoShopManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Models;

namespace AutoShopManager.Pages.Users
{
    public class CreateModel : PageModel
    {
		private readonly AutoShopManagerContext _context;
		public CreateModel(AutoShopManagerContext context)
		{

			_context = context;
		}

		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public User User { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Users == null || User == null)
			{
				return Page();
			}
			_context.Users.Add(User);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
