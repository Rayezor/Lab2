using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
	public class FleetContext : DbContext
	{
		private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore1;Trusted_Connection=False;";
		public DbSet<Car> cars { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
