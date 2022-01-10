using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjWebProject.Models;
using prjModel;

namespace prjWebProject.Controllers
{
    public class WritersController : Controller
    {
        private Writers writers = new Writers();
        // GET: Writer
        public ActionResult Index()
        {
            return View();
        }
    }
}