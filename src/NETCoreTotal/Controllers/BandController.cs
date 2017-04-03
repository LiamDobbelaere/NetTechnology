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
    public class BandController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult List()
        {
            ViewBag.bands = BandDA.Instance.Bands;

            return View();
        }

        [Route("[action]")]
        public IActionResult Ajax()
        {
            return View();
        }

        [Route("[action]")]
        public JsonResult JsonList()
        {
            return Json(BandDA.Instance.Bands);
        }

        [Route("[action]")]
        public IActionResult ListWithMembers()
        {
            ViewBag.bands = BandDA.Instance.Bands;

            return View();
        }

        [Route("[action]")]
        public IActionResult Add(string name, int year)
        {
            if (!string.IsNullOrEmpty(name) && year != 0)
            {
                BandDA.Instance.Bands.Add(new Band(name, year));

                return Content(name + ", " + year);
            }
            else
            {
                return Content("Bad querystring");
            }
        }


    }
}
