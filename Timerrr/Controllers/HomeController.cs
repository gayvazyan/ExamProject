using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timerrr.Models;

namespace Timerrr.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()


        {

            var startTiem = DateTime.UtcNow.AddSeconds(10);
            ViewBag.TiemExasise = startTiem;
            return View();
        }

        public IActionResult Privacy()
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
