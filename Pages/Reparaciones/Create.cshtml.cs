using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoShopManager.Data;


namespace AutoShopManager.Pages.Reparaciones
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
       public Reparacion Reparacion { get; set; } = default!;

       public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Reparaciones == null || Reparacion == null)
            {
                return Page();
            }
             _context.Reparaciones.Add(Reparacion); 

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
  

    }


}
