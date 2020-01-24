using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class UserRepository : IUserRepository
	{
		private AppDbContext context;

		public List<AppUser> Users { get { return context.Users.ToList(); } }

		public UserRepository(AppDbContext appDbContext)
		{
			context = appDbContext;
		}

		public void AddUser(AppUser user)
		{
			context.Users.Add(user);
			context.SaveChanges();
		}
	}
}
