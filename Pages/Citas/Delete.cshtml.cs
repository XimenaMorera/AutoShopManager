using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoShopManager.Data;
using AutoShopManager.Models;

namespace AutoShopManager.Pages.Citas
{
    public class DeleteModel : PageModel
    {
        private readonly AutoShopManagerContext _context;
        public DeleteModel(AutoShopManagerContext context)
        {
            _context = context;
        }
        [BindProperty]

		public Cita Cita { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Citas == null)
            {
                return NotFound();
            }
            var cita = await _context.Citas.FirstOrDefaultAsync(m => m.Id == id);
            if (cita == null)
            {
                return NotFound();
            }
            else
            {
				Cita = cita;
                _context.Citas.Remove(cita);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }


    }
}
