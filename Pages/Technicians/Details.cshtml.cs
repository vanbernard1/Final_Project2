using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project2.Models;

namespace Final_Project2.Pages.Technicians
{
    public class DetailsModel : PageModel
    {
        private readonly Final_Project2.Models.TicketDbContext _context;

        public DetailsModel(Final_Project2.Models.TicketDbContext context)
        {
            _context = context;
        }

        public Technician Technician { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Technician = await _context.Technician.FirstOrDefaultAsync(m => m.TechnicianId == id);

            if (Technician == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
