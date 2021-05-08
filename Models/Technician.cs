using System;
using System.Collections.Generic;

// Step 3: Create the data model
namespace Final_Project2.Models
{
    public class Technician
{
        public int TechnicianId {get; set;} // Primary Key
        public string TechName {get; set;}
        public string TechEmail {get; set;}
        public List<Ticket> Tickets {get; set;}
    }
   
}