using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class AppDbContext : IdentityDbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }
		public DbSet<Score> Scores { get; set; }
		public DbSet<ImportantPeopleModel> SignificantPeoples { get; set; }
	}
}
