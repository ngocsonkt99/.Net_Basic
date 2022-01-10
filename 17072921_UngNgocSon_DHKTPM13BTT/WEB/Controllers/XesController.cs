using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using Model;

namespace WEB.Controllers
{
    public class XesController : Controller
    {
        private XeContext db = new XeContext();

        // GET: Xes
        public ActionResult Index()
        {
            var xees = db.Xees.Include(x => x.LoaiXe);
            return View(xees.ToList());
        }

        // GET: Xes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xe xe = db.Xees.Find(id);
            if (xe == null)
            {
                return HttpNotFound();
            }
            return View(xe);
        }

        // GET: Xes/Create
        public ActionResult Create()
        {
            ViewBag.LoaiXeId = new SelectList(db.LoaiXees, "Id", "TenLoai");
            return View();
        }

        // POST: Xes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ten,Namsx,Gia,HinhAnh,Loai,LoaiXeId")] Xe xe)
        {
            if (ModelState.IsValid)
            {
                db.Xees.Add(xe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiXeId = new SelectList(db.LoaiXees, "Id", "TenLoai", xe.LoaiXeId);
            return View(xe);
        }

        // GET: Xes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xe xe = db.Xees.Find(id);
            if (xe == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiXeId = new SelectList(db.LoaiXees, "Id", "TenLoai", xe.LoaiXeId);
            return View(xe);
        }

        // POST: Xes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ten,Namsx,Gia,HinhAnh,Loai,LoaiXeId")] Xe xe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiXeId = new SelectList(db.LoaiXees, "Id", "TenLoai", xe.LoaiXeId);
            return View(xe);
        }

        // GET: Xes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Xe xe = db.Xees.Find(id);
            if (xe == null)
            {
                return HttpNotFound();
            }
            return View(xe);
        }

        // POST: Xes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Xe xe = db.Xees.Find(id);
            db.Xees.Remove(xe);
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
