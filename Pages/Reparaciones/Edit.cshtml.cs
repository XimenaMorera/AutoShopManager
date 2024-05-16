using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Citas
{
    public class EditModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public EditModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Cita Cita { get; set; } = default;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Citas==null)
            {
                return NotFound();  
            }

            var cita = await _context.Citas.FirstOrDefaultAsync(m => m.Id == id);
			if (cita == null)
			{
				return NotFound();
			}
            Cita = cita;
            return Page();
		}
		
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cita).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!CategoryExists(Cita.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index");
        }

		private bool CategoryExists(int id)
		{
            return (_context.Citas?.Any(e => e.Id == id)).GetValueOrDefault();
		}

		
    }
}
