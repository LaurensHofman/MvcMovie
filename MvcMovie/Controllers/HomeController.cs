using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Console.Beep();
            return RedirectToAction("Welcome", "HelloWorld");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Informatie van de applicatie";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Laurens Hofman";

            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
