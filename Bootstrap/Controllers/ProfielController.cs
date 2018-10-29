using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class ProfielController : Controller
    {
        // GET: Profiel
        public ActionResult MijnGegevens()
        {
            ViewBag.Message = "";
            return View();
        }
    }
}