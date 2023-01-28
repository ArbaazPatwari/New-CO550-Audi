using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using CW2B_RP_Audi_Team_4.Models;

namespace CW2B_RP_Audi_Team_4.Pages.OrderItems
{
    public class EditModel : PageModel
    {
        private readonly CW2B_RP_Audi_Team_4.Data.AudiContext _context;

        public EditModel(CW2B_RP_Audi_Team_4.Data.AudiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderItem OrderItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.OrderItems == null)
            {
                return NotFound();
            }

            var orderitem =  await _context.OrderItems.FirstOrDefaultAsync(m => m.OrderItemID == id);
            if (orderitem == null)
            {
                return NotFound();
            }
            OrderItem = orderitem;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OrderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(OrderItem.OrderItemID))
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

        private bool OrderItemExists(int id)
        {
          return _context.OrderItems.Any(e => e.OrderItemID == id);
        }
    }
}
