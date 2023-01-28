using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Pages.Wishlists
{
    public class DetailsModel : PageModel
    {
        private readonly CW2B_RP_Audi_Team_4.Data.AudiContext _context;

        public DetailsModel(CW2B_RP_Audi_Team_4.Data.AudiContext context)
        {
            _context = context;
        }

      public Wishlist Wishlist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Wishlist == null)
            {
                return NotFound();
            }

            var wishlist = await _context.Wishlist.FirstOrDefaultAsync(m => m.WishlistID == id);
            if (wishlist == null)
            {
                return NotFound();
            }
            else 
            {
                Wishlist = wishlist;
            }
            return Page();
        }
    }
}
