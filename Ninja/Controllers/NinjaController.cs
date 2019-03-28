using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ninja.Controllers
{
    public class NinjaController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            return View();
        }
    }
}