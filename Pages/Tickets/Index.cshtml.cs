using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        
        public string CurrentSort {get; set;}
        public SelectList SortList {get; set;}

        

        public async Task OnGetAsync()
        {         
            var query = _context.Ticket.Select(u => u);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "Name Ascending", Value = "name_asc" },
                new SelectListItem { Text = "Name Descending", Value = "name_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                // If user selected "first_asc", modify query to sort by first name ascending order
                case "name_asc": 
                    query = query.OrderBy(u => u.Name);
                    break;
                // If user selected "first_desc", modify query to sort by first name descending
                case "name_desc":
                    query = query.OrderByDescending(u => u.Name);
                    break;
                // Add more sorting cases as needed
            }  

            var tickets = from m in _context.Ticket
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
            tickets = tickets.Where(s => s.CampusName.Contains(SearchString));
            }

            Ticket = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
