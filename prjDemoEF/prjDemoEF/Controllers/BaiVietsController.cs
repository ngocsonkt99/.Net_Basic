using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prjDemoEF.Models;

namespace prjDemoEF.Controllers
{
    public class BaiVietsController : Controller
    {
        private Personal_FSoftEntities db = new Personal_FSoftEntities();

        // GET: BaiViets
        public ActionResult Index()
        {
            var baiViets = db.BaiViets.Include(b => b.LoaiBaiViet);
            return View(baiViets.ToList());
        }

        // GET: BaiViets/Details/5
        public ActionResult Details(string ma)
        {
            if (ma == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(ma);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            return View(baiViet);
        }

        // GET: BaiViets/Create
        public ActionResult Create()
        {
            ViewBag.maLoai = new SelectList(db.LoaiBaiViets, "maLoai", "tenLoai");
            return View();
        }

        // POST: BaiViets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maBaiViet,tuaBaiViet,noiDungTomTat,noiDungChinh,ngayDang,maLoai")] BaiViet baiViet)
        {
            if (ModelState.IsValid)
            {
                db.BaiViets.Add(baiViet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maLoai = new SelectList(db.LoaiBaiViets, "maLoai", "tenLoai", baiViet.maLoai);
            return View(baiViet);
        }

        // GET: BaiViets/Edit/5
        public ActionResult Edit(string ma)
        {
            if (ma == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(ma);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            ViewBag.maLoai = new SelectList(db.LoaiBaiViets, "maLoai", "tenLoai", baiViet.maLoai);
            return View(baiViet);
        }

        // POST: BaiViets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maBaiViet,tuaBaiViet,noiDungTomTat,noiDungChinh,ngayDang,maLoai")] BaiViet baiViet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baiViet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maLoai = new SelectList(db.LoaiBaiViets, "maLoai", "tenLoai", baiViet.maLoai);
            return View(baiViet);
        }

        // GET: BaiViets/Delete/5
        public ActionResult Delete(string ma)
        {
            if (ma == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(ma);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            return View(baiViet);
        }

        // POST: BaiViets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BaiViet baiViet = db.BaiViets.Find(id);
            db.BaiViets.Remove(baiViet);
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


        public ViewResult XemChiTiet(string maBV)
        {
            BaiViet bv = db.BaiViets.SingleOrDefault(n => n.maBaiViet == maBV);
            if (bv == null)
            {
                //tra ve trang bao loi
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.TenLoaiBV = db.LoaiBaiViets.Single(n => n.maLoai == bv.maLoai).tenLoai;
            ViewBag.DSComment = bv.Comments.OrderByDescending(x => x.ngayComment).ToList<Comment>();//ds cac comment cua bai viet
            ViewBag.BaiViet = bv;
            Session["maBaiViet"] = bv.maBaiViet;
            return View();
        }
    }
}
