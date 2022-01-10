using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Xe.Models;

namespace Xe.Controllers
{
    public class ListXesController : Controller
    {
        private CSDLXeEntities db = new CSDLXeEntities();

        // GET: ListXes
        public ActionResult Index()
        {
            var listXes = db.ListXes.Include(l => l.LoaiXe);
            return View(listXes.ToList());
        }

        // GET: ListXes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListXe listXe = db.ListXes.Find(id);
            if (listXe == null)
            {
                return HttpNotFound();
            }
            return View(listXe);
        }

        // GET: ListXes/Create
        public ActionResult Create()
        {
            ViewBag.loai = new SelectList(db.LoaiXes, "maloai", "tenloai");
            return View();
        }

        // POST: ListXes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ten,namsx,gia,hinhanh,loai")] ListXe listXe)
        {
            if (ModelState.IsValid)
            {
                db.ListXes.Add(listXe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.loai = new SelectList(db.LoaiXes, "maloai", "tenloai", listXe.loai);
            return View(listXe);
        }

        // GET: ListXes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListXe listXe = db.ListXes.Find(id);
            if (listXe == null)
            {
                return HttpNotFound();
            }
            ViewBag.loai = new SelectList(db.LoaiXes, "maloai", "tenloai", listXe.loai);
            return View(listXe);
        }

        // POST: ListXes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ten,namsx,gia,hinhanh,loai")] ListXe listXe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listXe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.loai = new SelectList(db.LoaiXes, "maloai", "tenloai", listXe.loai);
            return View(listXe);
        }

        // GET: ListXes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListXe listXe = db.ListXes.Find(id);
            if (listXe == null)
            {
                return HttpNotFound();
            }
            return View(listXe);
        }

        // POST: ListXes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListXe listXe = db.ListXes.Find(id);
            db.ListXes.Remove(listXe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
