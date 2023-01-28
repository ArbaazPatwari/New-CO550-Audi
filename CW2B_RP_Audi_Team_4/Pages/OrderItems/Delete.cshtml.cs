using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Pages.OrderItems
{
    public class DeleteModel : PageModel
    {
        private readonly CW2B_RP_Audi_Team_4.Data.AudiContext _context;

        public DeleteModel(CW2B_RP_Audi_Team_4.Data.AudiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public OrderItem OrderItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.OrderItems == null)
            {
                return NotFound();
            }

            var orderitem = await _context.OrderItems.FirstOrDefaultAsync(m => m.OrderItemID == id);

            if (orderitem == null)
            {
                return NotFound();
            }
            else 
            {
                OrderItem = orderitem;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.OrderItems == null)
            {
                return NotFound();
            }
            var orderitem = await _context.OrderItems.FindAsync(id);

            if (orderitem != null)
            {
                OrderItem = orderitem;
                _context.OrderItems.Remove(OrderItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
