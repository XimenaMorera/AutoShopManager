using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Data;


namespace AutoShopManager.Pages.Citas
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
        public Cita Cita { get; set; } = default!;

       public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Citas== null || Cita ==null)
            {
                return Page();
            }
            _context.Citas.Add(Cita);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
  

    }


}
