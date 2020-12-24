using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApp.Mvc.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Neon()
		{
			return View();
		}

		public IActionResult NeonGlory()
		{
			return View();
		}
	}
}
