using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjBusiness;
using prjData;
using prjDataAccess;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class TacgiasController : Controller
    {
        // GET: Tacgias
        KitchenContext db = new KitchenContext();
        Writers tg = new Writers();
        public ActionResult Index()
        {
            return View(tg.getWriter());
        }
        public ActionResult Edit(int Id)
        {
            Writer wedit = tg.GetwriterById(Id);
            return View(wedit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,Name")] Writer w)
        {
            //Writer wedit = tg.GetwriterById(Id);
            if (ModelState.IsValid)
            {
                tg.Edit(w);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Details(int Id)
        {
            Writer w = tg.GetwriterById(Id);
            return View(w);
        }

        public ActionResult Delete(int id)
        {
            Writer w = tg.GetwriterById(id);
            return View(w);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Writer w = tg.GetwriterById(id);
            tg.Remove(w);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Writer w)
        {
            if (ModelState.IsValid)
            {
                tg.Add(w);
                return RedirectToAction("Index");
            }
            return View(w);
        }

        public PartialViewResult TenTacGia()
        {
            return PartialView(tg.getWriter());
        }
        public ActionResult Baivietthuocloai(int id)
        {
            List<Recipe> lst = db.Recipe.Where(x => x.repID == id).ToList<Recipe>();
            return View(lst);
        }
    }
}