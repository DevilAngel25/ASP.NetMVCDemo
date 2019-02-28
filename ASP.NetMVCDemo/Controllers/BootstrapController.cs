using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NetMVCDemo.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BootstrapController : Controller
    {
        // GET: Bootstrap
        public ActionResult Index()
        {
            return View();
        }

        // GET: Buttons
        public ActionResult Buttons()
        {
            return View();
        }

        // GET: Buttons
        public ActionResult Progress()
        {
            return View();
        }
    }
}