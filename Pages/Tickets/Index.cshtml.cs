using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project2.Models;

namespace Final_Project2.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project2.Models.TicketDbContext _context;

        public IndexModel(Final_Project2.Models.TicketDbContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get;set; }

        public async Task OnGetAsync()
        {
            Ticket = await _context.Ticket.ToListAsync();
        }
    }
}
