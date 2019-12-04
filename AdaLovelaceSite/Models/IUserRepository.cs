using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public interface IUserRepository
	{
		List<User> Users { get; }
		void AddUser(User user);
	}
}
