using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project2.Models;

namespace Final_Project2.Pages.Technicians
{
    public class CreateModel : PageModel
    {
        private readonly Final_Project2.Models.TicketDbContext _context;

        public CreateModel(Final_Project2.Models.TicketDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Technician Technician { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Technician.Add(Technician);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
