using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryMVCMovie;

// * 180125
// 180208

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
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

        public IActionResult CalcAnderePagina()
        {
            ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = "Nog niet gekend.";

            string getal01 = "==",
                getal02 = "===";
            int intGetal01 = 458486463,
                intGetal02 = 48836456;

            try
            {
                getal01 = HttpContext.Request.Form["txtGetal01"].ToString();

                try
                {
                    getal02 = HttpContext.Request.Form["txtGetal02"].ToString();

                    try
                    {
                        intGetal01 = int.Parse(getal01);
                        try
                        {
                            intGetal02 = int.Parse(getal02);
                            ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = (intGetal01 + intGetal02).ToString();
                        }
                        catch (Exception)
                        {
                            ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = "Is niet berekenbaar [180208AA]";
                        }
                    }
                    catch (Exception)
                    {
                        ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = "Is niet berekenbaar [180208BB]";
                    }
                }
                catch (Exception)
                {
                    ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = "Is niet berekenbaar [180208CC]";
                }
            }
            catch (Exception)
            {
                ViewData[MyConstants.SW_CalcAnderePagina_Resultaat] = "Is niet berekenbaar [180208DD]";
            }

            return View();
        }

        public IActionResult MakeCookie()
        {
            //P (pre)    : De nodige waarden worden aangeleverd
            //P (post)   : Het koekje is gemaakt
            //G (gebruik): In view CalcAnderePagina

            try
            {
                ViewData["Resultaat"] = HttpContext.Request.Form["txtCookiesContent"].ToString();
                ViewData["txaResultaat"] = "Test";
                Console.Beep();
            }
            catch (Exception)
            {
                ViewData["txaResultaat"] = "The cookie cannot be created yet.";
            }

            return View("CalcAnderePagina");
        }
    }
}
