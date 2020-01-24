using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public interface IUserRepository
	{
		List<AppUser> Users { get; }
		void AddUser(AppUser user);
	}
}
