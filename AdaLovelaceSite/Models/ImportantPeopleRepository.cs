using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaLovelaceSite.Models
{
	public class ImportantPeopleRepository
	{
		private static List<ImportantPeopleModel> people = new List<ImportantPeopleModel>();
		public static List<ImportantPeopleModel> People { get { return people; } }

		static ImportantPeopleRepository()
		{
			TestData();
		}

		public static void AddPeople(ImportantPeopleModel people)
		{
			People.Add(people);
		}

		static void TestData()
		{
			ImportantPeopleModel person1 = new ImportantPeopleModel()
			{
				FirstName = "Ada",
				LastName = "Lovelace",
				BirthDate = "December 10, 1815",
				DeathDate = "November 27, 1852",
				Children = 3,
				RecognizedFor = "Mathematics, Computing, Writing",
			};
			People.Add(person1);

			ImportantPeopleModel person2 = new ImportantPeopleModel()
			{
				FirstName = "Charles",
				LastName = "Babbage",
				BirthDate = "December 26, 1791",
				DeathDate = "October 18, 1871",
				Children = 8,
				RecognizedFor = "Mathematics, Engineering, Politics, Computer Science",
			};
			People.Add(person2);

			ImportantPeopleModel person3 = new ImportantPeopleModel()
			{
				FirstName = "Andrew",
				LastName = "Crosse",
				BirthDate = "June 17, 1784",
				DeathDate = "July 6, 1855",
				Children = 10,
				RecognizedFor = "Electrocrystallization",
			};
			People.Add(person3);

			ImportantPeopleModel person4 = new ImportantPeopleModel()
			{
				FirstName = "David",
				LastName = "Brewster",
				BirthDate = "December 11, 1781",
				DeathDate = "February 10, 1868",
				Children = 5,
				RecognizedFor = "Mathematics, Physics, Astronomy",
			};
			People.Add(person4);

			ImportantPeopleModel person5 = new ImportantPeopleModel()
			{
				FirstName = "Charles",
				LastName = "Wheatstone",
				BirthDate = "February 6, 1802",
				DeathDate = "October 19, 1875",
				Children = 5,
				RecognizedFor = "Physics",
			};
			People.Add(person5);

			ImportantPeopleModel person6 = new ImportantPeopleModel()
			{
				FirstName = "Michael",
				LastName = "Faraday",
				BirthDate = "September 22, 1791",
				DeathDate = "August 25, 1867",
				Children = 0,
				RecognizedFor = "Physics, Chemistry",
			};
			People.Add(person6);
		}
	}
}
