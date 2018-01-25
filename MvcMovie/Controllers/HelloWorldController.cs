using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// * 180125


    // Dag GertJan

    // In de Solution Explorer zie je dus onder het mapje Views 3 mapjes
    // Home en Shared zijn standaard. HelloWorld hebben we zelf gemaakt.

    //Index is wat standaard gebruikt wordt als "homepage". In Startup.cs staat dus ook mapje Home + index als startup dus daarom dat
    //Dat je die pagina van microsoft zelf krijgt als beginpagina. Daar (Home -> Index.cshtml) kan je ook zelf beetje prutsen in de HTML code
    //om tekst te wijzigen.

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Als je de site laat runnen ga je ook automatisch naar de Home > Index.cshtml
        //Als je naar een eigen pagina wil gaan (zoals gemaakt in HelloWorld > Index.cshtml) dan moet je ipv
        // "http://localhost:xxxxx" er  " /HelloWorld " aan toevoegen (bv: http://localhost:52203/HelloWorld)
        // (let natuurlijk wel op, het getal van de localhost zal bij jou een andere zijn)
        // Dit opent de index van je HelloWorld mapje

        // De ViewData zijn de variabelen die meegegeven worden
        // Dit kun je zien door gewoon http://localhost:52203/HelloWorld te laten runnen en je zal zien dat de gegevens GertJan en "9 keer"
        // mee verstuurd worden.

        // Je kan ook de variabelen dat je meestuurt zelf waardes voor invoeren (de gegevens GertJan en "9 keer" zijn gewoon terugvalwaarden
        // Indien geen waarden meegegeven zouden worden.
        // Zelf waardes invoeren kun je doen door bijvoorbeeld dit te doen: http://localhost:52203/HelloWorld?Naam=LaurensHofman&AantalKeer=20
        // Met een vraagteken naar de pagina en dan aan de waarden (met de naam van tussen de vierkante haakjes hieronder) toe te kennen.
        

        public IActionResult Index(string naam = "GertJan", int aantalKeer = 9)
        {
            ViewData["Naam"] = naam;
            ViewData["AantalKeer"] = aantalKeer;
            return View();
        }

        // Deze methode kan je oproepen door http://localhost:52203/HelloWorld/Welcome in te voeren als url.
        // Deze returned dan enkel maar 1 string gevuld met "Welcome!"

        public string Welcome()
        {
            return "Welcome!";
        }

        // Om deze methoden op te roepen moet je gebruik maken van http://localhost:52203/HelloWorld/NaamEnAantal
        // Hier ook kan je de waarden manueel wijzigen door ?Naam=LaurensHofman te doen

        public string NaamEnAantal(string naam = "GertJan", int aantalKeer = 5)
        {
            return $"Hallo {naam}! #{aantalKeer}";
        }


        // Gelijkaardig met bovenstaande methode kan je http://localhost:52203/HelloWorld/MijnSom doen en waarden toekennen aan de hand van
        // ?Getal1=333&Getal2=50

        public string MijnSom(int getal1 = 20, int getal2 = 33)
        {
            return $"De som van {getal1} + {getal2} is {(getal1 + getal2).ToString()}" ;
            // Hier werkt $ voor een string weeral om tussen accolades gewoon de C# variabelen en code in te kunnen voegen
        }
    }
}
