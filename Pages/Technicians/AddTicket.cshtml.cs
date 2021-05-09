using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Final_Project2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project2.Pages
{
    public class AddTicketModel : PageModel
    {
        private readonly ILogger<AddTicketModel> _logger;
        private readonly TicketDbContext _context; // Ticket Database context
        [BindProperty]
        public Ticket Ticket {get; set;}
        public SelectList TicketsDropDown {get; set;}

        public AddTicketModel(TicketDbContext context, ILogger<AddTicketModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            TicketsDropDown = new SelectList(_context.Ticket.ToList(), "TicketID", "Title");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ticket.Add(Ticket);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}