using Microsoft.EntityFrameworkCore;
using StudentService.Models;

namespace StudentService.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Student> Students { get; set; }
		public DbSet<Payment> Payments { get; set; }
	}
}
