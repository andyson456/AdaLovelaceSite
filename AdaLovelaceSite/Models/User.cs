using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class User
	{
		private List<Score> userScores = new List<Score>();

		public Guid UserKey { get; set; }
		public string UserName { get; set; }

		public List<Score> UserScores { get { return userScores; } }
	}
}
