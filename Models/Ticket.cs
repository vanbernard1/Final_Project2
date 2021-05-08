using System;
using System.Collections.Generic;

namespace Final_Project2.Models
{
    public class Ticket
    {
        public int TicketId {get; set;}	// Primary Key
        public DateTime Date {get; set;}
        public string Name {get; set;}
        public int RoomNumber {get; set;}
        public string CampusName {get; set;}
        public string RequestType {get; set;}
        public int TechnicianId {get; set;}
        public Technician Technician {get; set;}
    }
}