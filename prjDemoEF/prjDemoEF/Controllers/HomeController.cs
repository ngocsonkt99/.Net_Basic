using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjDemoEF.Models;

namespace prjDemoEF.Controllers
{
    public class HomeController : Controller
    {
        Personal_FSoftEntities db = new Personal_FSoftEntities();
        public ActionResult Index()
            //DS bai viet
        {
            return View(db.BaiViets.ToList<BaiViet>());
        }
    }
}