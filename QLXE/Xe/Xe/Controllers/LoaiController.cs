using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xe.Models;

namespace Xe.Controllers
{

    public class LoaiController : Controller
    {
        private CSDLXeEntities db = new CSDLXeEntities();
        // GET: Loai
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public PartialViewResult Loaipartial()
        {
            List<LoaiXe> lxe = db.LoaiXes.ToList<LoaiXe>();
            return PartialView(lxe);
        }
        public ActionResult Xeinloai(string loaiid = "ND")
        {
            LoaiXe lst = db.LoaiXes.Find(loaiid);
            if (lst == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<ListXe> l_xe = db.ListXes.Where(x => x.loai == loaiid).ToList<ListXe>();
            if (l_xe.Count == 0)
            {
                ViewBag.Xe = " Khong co xe nao thuoc loai nay";
            }
            else
                ViewBag.Xe = lst.tenloai;
            return View(l_xe);
        }
    }
}