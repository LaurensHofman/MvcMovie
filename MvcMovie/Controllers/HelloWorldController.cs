using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// * 180125

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //public IActionResult Index(string naam = "GertJan", int aantalKeer = 9)
        //{
        //    ViewData["Naam"] = naam;
        //    ViewData["AantalKeer"] = aantalKeer;
        //    return View();
        //}

        public IActionResult Index(int aantalKeer = 9)
        {
            ViewData["Naam"] = DBTest.GetDefaultLanguage();
            ViewData["AantalKeer"] = aantalKeer;
            return View();
        }

        public IActionResult DoeBewerking()
        {
            string Getal01 = HttpContext.Request.Form["txtGetal01"].ToString();
            string Getal02 = HttpContext.Request.Form["txtGetal02"].ToString();

            string som = "";

            try
            {
                som = (int.Parse(Getal01) + int.Parse(Getal02)).ToString();
            }
            catch (Exception ex)
            {
                som = "Oopsie :-( [180202A]" + " (" + ex.Message + ")";
                Debug.WriteLine("HelloWorld@180202_r46;" + ex.StackTrace + ".");
            }

            ViewData["Som"] = som;
            ViewData["Getal01"] = Getal01;
            ViewData["Getal02"] = Getal02;

            return View("Welcome");
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult MultiplyText()
        {
            ViewData["AantalKeer"] = int.Parse(HttpContext.Request.Form["txtAantalKeer"].ToString());
            ViewData["InputText"] = HttpContext.Request.Form["txtInputText"];

            ViewData["CowOrText"] = HttpContext.Request.Form["cbCowOrText"].ToString().Equals("true") ? "Cow" : "Text";

            return View("Welcome");
        }

        //public string NaamEnAantal(string naam = "GertJan", int aantalKeer = 5)
        //{
        //    return $"Hallo {naam}! #{aantalKeer}";
        //}
        
        //public string MijnSom(int getal1 = 20, int getal2 = 33)
        //{
        //    return $"De som van {getal1} + {getal2} is {(getal1 + getal2).ToString()}" ;
        //}
    }
}
