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

                context.Ticket.AddRange(
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Rupert Giles",
                        RoomNumber = 110,
                        CampusName = "Sunnydale High",
                        RequestType = "Hardware",
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 7),
                        Name = "Mr. Belding",
                        RoomNumber = 111,
                        CampusName = "Bayside High",
                        RequestType = "PA System"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 9, 12),
                        Name = "Mr. Hand",
                        RoomNumber = 112,
                        CampusName = "Ridgemont",
                        RequestType = "Teacher PC"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 8, 16),
                        Name = "Mr. Holland",
                        RoomNumber = 113,
                        CampusName = "JFK High",
                        RequestType = "Peripherals"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Joe Clark",
                        RoomNumber = 115,
                        CampusName = "Eastside High",
                        RequestType = "Student PC"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Richard Vernon",
                        RoomNumber = 116,
                        CampusName = "Shermer High",
                        RequestType = "Printer Install"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Coach Calhoun",
                        RoomNumber = 117,
                        CampusName = "Rydell High",
                        RequestType = "Teacher PC"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 5, 7),
                        Name = "Mr. Hall",
                        RoomNumber = 118,
                        CampusName = "Beverly Hills High",
                        RequestType = "New Printer"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 9),
                        Name = "Mr. Cleary",
                        RoomNumber = 119,
                        CampusName = "St. Matthews High School",
                        RequestType = "SmartBoard"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 10, 27),
                        Name = "Wolfman Blumford",
                        RoomNumber = 120,
                        CampusName = "Pacific Coast High",
                        RequestType = "Software"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 15),
                        Name = "Scott Clarke",
                        RoomNumber = 121,
                        CampusName = "Hawkins Middle School",
                        RequestType = "AV Request"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 4, 20),
                        Name = "Alaric Saltzman",
                        RoomNumber = 122,
                        CampusName = "Mystic Falls High",
                        RequestType = "Login Issues"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 8, 24),
                        Name = "Jennifer Calendar",
                        RoomNumber = 123,
                        CampusName = "Sunnydale High",
                        RequestType = "Bluetooth Setup"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 12, 4),
                        Name = "Principal Snyder",
                        RoomNumber = 124,
                        CampusName = "Sunnydale High",
                        RequestType = "Hardware"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 11, 15),
                        Name = "Coach Teague",
                        RoomNumber = 125,
                        CampusName = "Smallville High School",
                        RequestType = "Domain Password Reset"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 24),
                        Name = "Walter White",
                        RoomNumber = 100,
                        CampusName = "J.P. Wynne High",
                        RequestType = "Hardware"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 28),
                        Name = "Principal Skinner",
                        RoomNumber = 101,
                        CampusName = "Springfield Elementary",
                        RequestType = "Software"
                    },

                    new Ticket
                    {
                        Date = new DateTime(2021, 3, 18),
                        Name = "Mr. Feeny",
                        RoomNumber = 102,
                        CampusName = "John Adams High",
                        RequestType = "Printer"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 3, 19),
                        Name = "Ms. Bliss",
                        RoomNumber = 103,
                        CampusName = "JFK Jr. High",
                        RequestType = "SmartBoard"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 30),
                        Name = "Mr. Mackey",
                        RoomNumber = 104,
                        CampusName = "Southpark Elementary",
                        RequestType = "Software"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 1, 16),
                        Name = "Mr. Kotter",
                        RoomNumber = 105,
                        CampusName = "James Buchanan High",
                        RequestType = "Hardware"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 6, 8),
                        Name = "Jessica Day",
                        RoomNumber = 106,
                        CampusName = "LA High",
                        RequestType = "Desktop Install"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 6, 12),
                        Name = "Mr. Collins",
                        RoomNumber = 107,
                        CampusName = "McKinley High",
                        RequestType = "New Monitor"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 22),
                        Name = "Mr. Katimski",
                        RoomNumber = 108,
                        CampusName = "Liberty High",
                        RequestType = "Chromebook"
                    },
                    new Ticket
                    {
                        Date = new DateTime(2021, 2, 24),
                        Name = "Tamara Jacobs",
                        RoomNumber = 109,
                        CampusName = "Capeside High",
                        RequestType = "Hardware"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}