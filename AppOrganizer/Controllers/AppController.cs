using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppOrganizer.Controllers
{
    [Authorize(Roles="admin, developer")]
    public class AppController : Controller
    {
        // GET: App

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ContentResult EnclosedApp()
        {
            return Content("This is an enclosed App.");
        }

        public ContentResult ViewableApp()
        {
            return Content("This is a viewable App.");
        }
    }
}