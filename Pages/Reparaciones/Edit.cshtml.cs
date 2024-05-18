using AutoShopManager.Data;
using AutoShopManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoShopManager.Pages.Reparaciones
{
    public class EditModel : PageModel
    {
        private readonly AutoShopManagerContext _context;

        public EditModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        [BindProperty]
     
		public Reparacion Reparacion { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Reparaciones == null)
            {
                return NotFound();  
            }

            var reparacion = await _context.Reparaciones.FirstOrDefaultAsync(m => m.Id == id);
			if (reparacion == null)
			{
				return NotFound();
			}
			Reparacion = reparacion;
			return Page();
		}
		
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Reparacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!ReparacionExists(Reparacion.Id))
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

		private bool ReparacionExists(int id)
		{
            return (_context.Reparaciones?.Any(e => e.Id == id)).GetValueOrDefault();
		}

		
    }
}
