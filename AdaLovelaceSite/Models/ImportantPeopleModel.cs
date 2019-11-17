using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class ImportantPeopleModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string BirthDate { get; set; }
		public string DeathDate { get; set; }
		public int Children { get; set; }
		public string RecognizedFor { get; set; }
	}
}
