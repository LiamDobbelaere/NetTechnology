using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCoreTotal.Controllers
{
    [Route("[controller]")]
    public class BandmemberController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            ViewBag.bands = BandDA.Instance.Bands;

            return View();
        }

        [Route("[action]")]
        public IActionResult List()
        {
            ViewBag.bands = BandDA.Instance.Bands;

            return View();
        }

        [Route("[action]")]
        public IActionResult Add(string name, int age, Gender gender, bool alive, string bandName)
        {
            if (!string.IsNullOrEmpty(name) && age > 0 && !string.IsNullOrEmpty(bandName))
            {
                Bandmember newMember = new Bandmember(name, age, gender, alive);

                bool found = false;
                foreach (Band band in BandDA.Instance.Bands)
                {
                    if (band.Name.ToLower() == bandName.ToLower())
                    {
                        band.Members.Add(newMember);
                        found = true;

                        break;
                    }
                }

                if (!found) return Content("No such band");
                else return Content(name + ", " + age + ", " + gender + ", " + alive + ", " + bandName);
            }
            else
            {
                return Content("Bad querystring");
            }
        }
    }
}
