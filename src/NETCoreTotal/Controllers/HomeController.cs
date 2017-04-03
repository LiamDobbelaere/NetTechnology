using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCoreTotal.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("{*url}", Order = 100)]
        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("[action]/{type}/{name}/{age}")]
        [Route("[action]/{type}/{name}/{year}/{gender}/{band}")]
        public IActionResult Maak(string type, string name, int year, int age, Gender gender, string band)
        {
            switch (type)
            {
                case "Band":
                    BandDA.Instance.Bands.Add(new Band(name, year));

                    ViewBag.message = "OK";
                    break;
                case "BandLid":
                    bool found = false;

                    foreach (Band bandObject in BandDA.Instance.Bands)
                    {
                        if (bandObject.Name == band)
                        {
                            found = true;

                            bandObject.Members.Add(new Bandmember(name, age, gender, true));
                        }
                    }
                    
                    if (!found)
                    {
                        ViewBag.message = "Did not find band " + band;
                    } else {
                        ViewBag.message = "OK";
                    }

                    break;
                default:
                    ViewBag.message = "Invalid type " + type;
                    break;
            }

            return View();
        }


        [Route("[action]/Naam/{naam}/Jaar/{jaar}")]
        public IActionResult MaakBand(string naam, int jaar)
        {
            BandDA.Instance.Bands.Add(new Band(naam, jaar));

            ViewBag.message = "OK";
            return View();
        }

        [Route("[action]/Naam/{naam}/Jaar/{leeftijd}/Geslacht/{geslacht}/Band/{band}")]
        public IActionResult MaakBandLid(string naam, int leeftijd, Gender geslacht, string band)
        {
            bool found = false;

            foreach (Band bandObject in BandDA.Instance.Bands)
            {
                if (bandObject.Name == band)
                {
                    found = true;

                    bandObject.Members.Add(new Bandmember(naam, leeftijd, geslacht, true));
                }
            }

            if (!found)
            {
                ViewBag.message = "Did not find band " + band;
            }
            else
            {
                ViewBag.message = "OK";
            }

            return View();
        }

        [Route("[action]/JS")]
        public JsonResult MaakLijst()
        {
            return Json(BandDA.Instance.Bands);
        }
    }
}
