using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Pages.CarImages
{
    public class DeleteModel : PageModel
    {
        private readonly CW2B_RP_Audi_Team_4.Data.AudiContext _context;

        public DeleteModel(CW2B_RP_Audi_Team_4.Data.AudiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CarImage CarImage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CarImages == null)
            {
                return NotFound();
            }

            var carimage = await _context.CarImages.FirstOrDefaultAsync(m => m.CarImageID == id);

            if (carimage == null)
            {
                return NotFound();
            }
            else 
            {
                CarImage = carimage;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CarImages == null)
            {
                return NotFound();
            }
            var carimage = await _context.CarImages.FindAsync(id);

            if (carimage != null)
            {
                CarImage = carimage;
                _context.CarImages.Remove(CarImage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
