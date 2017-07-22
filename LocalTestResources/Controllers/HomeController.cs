using LocalTestResources.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalTestResources.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var vm = new UserDetails { City = "myself" };
            return View("Index", vm);
        }
    }
}