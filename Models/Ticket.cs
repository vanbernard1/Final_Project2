using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Final_Project2.Models
{
    public class Ticket
    {
        public int TicketId {get; set;}	// Primary Key
        
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name {get; set;}

        [StringLength(5)]
        [Required]
        public int RoomNumber {get; set;}

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string CampusName {get; set;}


        public string RequestType {get; set;}

        [Display(Name = "Technician")]
        [Required]
        public int TechnicianId {get; set;}
        public Technician Technician {get; set;}
    }
}