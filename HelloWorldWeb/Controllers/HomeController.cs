namespace HelloWorldWeb.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using HelloWorldWeb.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> logger;
        private readonly TeamInfo teamInfo;
        public HomeController(ILogger<HomeController> logger)
		{
			this.logger = logger;
            teamInfo = new TeamInfo
            {
                Name = "Team3",
                TeamMembers = new List<string>()
            };
			teamInfo.TeamMembers.AddRange(new string [] { "Leon", "Radu", "Teona", "Geroge", "Dragos", "Claudia" });
			
		}

		[HttpGet]
		public int GetCount()
        {
			return teamInfo.TeamMembers.Count;
        }
		public void AddTeamMember(string name)
        {
			teamInfo.TeamMembers.Add(name);
        }

		public IActionResult Index()
		{
			return View(teamInfo);
		}

		public IActionResult Privacy()
		{
			return View(teamInfo);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
