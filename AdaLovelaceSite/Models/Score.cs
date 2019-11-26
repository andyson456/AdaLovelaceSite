using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class Score
	{
		public Guid ScoreKey { get; set; }
		public string Answer { get; set; }
		public string RightAnswer { get; set; }
		public bool IsRight { get; set; }
		public int ScoreTotal { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;
	}
}
