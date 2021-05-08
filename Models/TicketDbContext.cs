using Microsoft.EntityFrameworkCore;

namespace Final_Project2.Models
{
	public class TicketDbContext : DbContext
	{
		public TicketDbContext (DbContextOptions<TicketDbContext> options)
			: base(options)
		{
		}
		public DbSet<Ticket> Ticket {get; set;}
		public DbSet<Technician> Technician {get; set;}
		
	}
}