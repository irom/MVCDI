using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ServicesDI;

namespace MVCDI.Controllers
{
    public class HomeController : Controller
    {
        IService _service;
        public HomeController(IService service)
        {
            _service = service;
        }

        public IActionResult About()
        {
            ViewBag.message = _service.Message();

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
