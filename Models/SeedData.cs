using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace Final_Project2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TicketDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<TicketDbContext>>()))
            {
                // Look for any tickets.
                if (context.Ticket.Any())
                {
                    return; // DB has been seeded
                }

                context.Technician.AddRange(
                    new Technician {TechName = "Vanessa Bernard", TechEmail = "vbernard@bisd.net"},
                    new Technician {TechName = "DJ Rambo", TechEmail = "drambo@bisd.net"},
                    new Technician {TechName = "Jason Bernard", TechEmail = "jbernard@bisd.net"},
                    new Technician {TechName = "Madeline Bernard", TechEmail = "mbernard@bisd.net"},
                    new Technician {TechName = "Zian Bernard", TechEmail = "zbernard@bisd.net"}
                );

                context.Ticket.AddRange(
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Rupert Giles",
                        RoomNumber = 110,
                        CampusName = "Sunnydale High",
                        RequestType = "Hardware",
                        TechnicianId = 2
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 7),
                        Name = "Mr. Belding",
                        RoomNumber = 111,
                        CampusName = "Bayside High",
                        RequestType = "PA System",
                        TechnicianId = 3
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 9, 12),
                        Name = "Mr. Hand",
                        RoomNumber = 112,
                        CampusName = "Ridgemont",
                        RequestType = "Teacher PC", 
                        TechnicianId = 4
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 8, 16),
                        Name = "Mr. Holland",
                        RoomNumber = 113,
                        CampusName = "JFK High",
                        RequestType = "Peripherals",
                        TechnicianId = 5
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Joe Clark",
                        RoomNumber = 115,
                        CampusName = "Eastside High",
                        RequestType = "Student PC",
                        TechnicianId = 1
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Richard Vernon",
                        RoomNumber = 116,
                        CampusName = "Shermer High",
                        RequestType = "Printer Install",
                        TechnicianId = 2
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Coach Calhoun",
                        RoomNumber = 117,
                        CampusName = "Rydell High",
                        RequestType = "Teacher PC",
                        TechnicianId = 3
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 5, 7),
                        Name = "Mr. Hall",
                        RoomNumber = 118,
                        CampusName = "Beverly Hills High",
                        RequestType = "New Printer",
                        TechnicianId = 4
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Mr. Cleary",
                        RoomNumber = 119,
                        CampusName = "St. Matthews High School",
                        RequestType = "SmartBoard",
                        TechnicianId = 5
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 10, 27),
                        Name = "Wolfman Blumford",
                        RoomNumber = 120,
                        CampusName = "Pacific Coast High",
                        RequestType = "Software",
                        TechnicianId = 1
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 15),
                        Name = "Scott Clarke",
                        RoomNumber = 121,
                        CampusName = "Hawkins Middle School",
                        RequestType = "AV Request",
                        TechnicianId = 2
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 20),
                        Name = "Alaric Saltzman",
                        RoomNumber = 122,
                        CampusName = "Mystic Falls High",
                        RequestType = "Login Issues",
                        TechnicianId = 3
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 8, 24),
                        Name = "Jennifer Calendar",
                        RoomNumber = 123,
                        CampusName = "Sunnydale High",
                        RequestType = "Bluetooth Setup",
                        TechnicianId = 4
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 12, 4),
                        Name = "Principal Snyder",
                        RoomNumber = 124,
                        CampusName = "Sunnydale High",
                        RequestType = "Hardware",
                        TechnicianId = 5
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 11, 15),
                        Name = "Coach Teague",
                        RoomNumber = 125,
                        CampusName = "Smallville High School",
                        RequestType = "Domain Password Reset",
                        TechnicianId = 1
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 24),
                        Name = "Walter White",
                        RoomNumber = 100,
                        CampusName = "J.P. Wynne High",
                        RequestType = "Hardware",
                        TechnicianId = 2
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 28),
                        Name = "Principal Skinner",
                        RoomNumber = 101,
                        CampusName = "Springfield Elementary",
                        RequestType = "Software",
                        TechnicianId = 3
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 3, 18),
                        Name = "Mr. Feeny",
                        RoomNumber = 102,
                        CampusName = "John Adams High",
                        RequestType = "Printer",
                        TechnicianId = 4
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 3, 19),
                        Name = "Ms. Bliss",
                        RoomNumber = 103,
                        CampusName = "JFK Jr. High",
                        RequestType = "SmartBoard",
                        TechnicianId = 5
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 30),
                        Name = "Mr. Mackey",
                        RoomNumber = 104,
                        CampusName = "Southpark Elementary",
                        RequestType = "Software",
                        TechnicianId = 1
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 16),
                        Name = "Mr. Kotter",
                        RoomNumber = 105,
                        CampusName = "James Buchanan High",
                        RequestType = "Hardware",
                        TechnicianId = 2
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 6, 8),
                        Name = "Jessica Day",
                        RoomNumber = 106,
                        CampusName = "LA High",
                        RequestType = "Desktop Install",
                        TechnicianId = 3
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 6, 12),
                        Name = "Mr. Collins",
                        RoomNumber = 107,
                        CampusName = "McKinley High",
                        RequestType = "New Monitor",
                        TechnicianId = 4
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 22),
                        Name = "Mr. Katimski",
                        RoomNumber = 108,
                        CampusName = "Liberty High",
                        RequestType = "Chromebook",
                        TechnicianId = 5
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 24),
                        Name = "Tamara Jacobs",
                        RoomNumber = 109,
                        CampusName = "Capeside High",
                        RequestType = "Hardware",
                        TechnicianId = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}