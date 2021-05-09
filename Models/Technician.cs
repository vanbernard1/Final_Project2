using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Step 3: Create the data model
namespace Final_Project2.Models
{
    public class Technician
{
        public int TechnicianId {get; set;} // Primary Key
        
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string TechName {get; set;}
        
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string TechEmail {get; set;}
        
        public List<Ticket> Tickets {get; set;}
        
        public int TicketId {get; set;}
    }
   
}