using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class User
	{
		public int UserID { get; set; }
		public Guid UserKey { get; set; }
		[Required]
		public string UserName { get; set; }
		public int Score { get; set; }
	}
}
