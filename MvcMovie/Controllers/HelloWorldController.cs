using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// * 180125

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index(string naam = "GertJan", int aantalKeer = 9)
        {
            ViewData["Naam"] = naam;
            ViewData["AantalKeer"] = aantalKeer;
            return View();
        }

        //public string Welcome()
        //{
        //    return "Welcome!";
        //}

        public IActionResult Welcome()
        {
            return View();
        }
        
        public string NaamEnAantal(string naam = "GertJan", int aantalKeer = 5)
        {
            return $"Hallo {naam}! #{aantalKeer}";
        }
        
        public string MijnSom(int getal1 = 20, int getal2 = 33)
        {
            return $"De som van {getal1} + {getal2} is {(getal1 + getal2).ToString()}" ;
        }
    }
}
