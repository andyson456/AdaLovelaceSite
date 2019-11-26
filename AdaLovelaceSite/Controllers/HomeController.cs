using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdaLovelaceSite.Models;

namespace AdaLovelaceSite.Controllers
{
	public class HomeController : Controller
	{
		User user;
		Score score;

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AdaLovelace()
		{
			return View();
		}

		public IActionResult SignificantPeople()
		{
			return View();
		}

		public IActionResult QuizResult(Microsoft.AspNetCore.Http.IFormCollection frm)
		{
			List<User> users = UserRepository.Users;
			string radio = frm["Question1"].ToString();
			ViewData["radio"] = radio;
			return View(users);
		}

		[HttpGet]
		public IActionResult QuizPage()
		{
			return View();
		}

		[HttpPost]
		public RedirectToActionResult QuizPage(string name, int score, string rightAnswer, string rightAnswer2,
					string rightAnswer3, string rightAnswer4, string rightAnswer5)
		{
			user = new User();
			user.UserKey = Guid.NewGuid();
			user.UserName = name;

			if (rightAnswer == "1843")
			{
				score++;
				user.Score = score;
			}

			if (rightAnswer2 == "8" | rightAnswer2 == "Eight" | rightAnswer2 == "eight")
			{
				score++;
				user.Score = score;
			}

			if (rightAnswer3 == "The Difference Engine" | rightAnswer3 == "Difference Engine")
			{
				score++;
				user.Score = score;
			}

			if (rightAnswer4 == "Electrocrystallization")
			{
				score++;
				user.Score = score;
			}

			if (rightAnswer5 == "Bernoulli Numbers" | rightAnswer5 == "The Bernoulli Numbers")
			{
				score++;
				user.Score = score;
			}

			UserRepository.AddUser(user);

			return RedirectToAction("QuizResult");
		}

		public IActionResult RedirectToQuizPage()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
