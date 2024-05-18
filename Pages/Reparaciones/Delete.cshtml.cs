using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoShopManager.Data;
using AutoShopManager.Models;

namespace AutoShopManager.Pages.Reparaciones
{
    public class DeleteModel : PageModel
    {
        private readonly AutoShopManagerContext _context;
        public DeleteModel(AutoShopManagerContext context)
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
            else
            {
				Reparacion = reparacion;
                _context.Reparaciones.Remove(reparacion);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }


    }
}
