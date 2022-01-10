using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using prjData;

namespace WebProject.Controllers
{
    public class WritersController : Controller
    {
        Writers tacgia = new Writers();
        //private Writers writers = new Writers();
        // GET: Writer
        public ActionResult Index()
        {
            return View(tacgia.getWriter());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Writer writer)
        {
            if (ModelState.IsValid)
            {
                tacgia.Add(writer);
                return RedirectToAction("Index");
            }
            return View(writer);
        }
    }
}