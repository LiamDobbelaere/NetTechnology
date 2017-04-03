using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KoolUtils;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCoreTotal.Controllers
{
    [Route("[controller]")]
    public class BerekenController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]/{value}")]
        public IActionResult Faculteit(int value)
        {
            ViewBag.value = value;
            ViewBag.result = new Faculteit(value).Calculate();

            return View();
        }

        [Route("[action]/{type}/{value}")]
        public IActionResult Temperatuur(string type, float value)
        {
            ViewBag.value = value;

            switch (type)
            {
                case "inFahrenheit":
                    ViewBag.type = "Fahrenheit";
                    ViewBag.result = new Temperatuur(value).Farenheit;
                    break;
                case "inKelvin":
                    ViewBag.type = "Kelvin";
                    ViewBag.result = new Temperatuur(value).Kelvin;
                    break;
                default:
                    ViewBag.type = "?";
                    ViewBag.result = 0;
                    break;
            }

            return View();
        }
    }
}
