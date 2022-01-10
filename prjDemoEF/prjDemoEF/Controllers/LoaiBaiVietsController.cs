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
    public class LoaiBaiVietsController : Controller
    {

        // GET: LoaiBaiViets
        Personal_FSoftEntities db = new Personal_FSoftEntities();
        public PartialViewResult Loaibaiviet()
        {
            return PartialView(db.LoaiBaiViets.ToList<LoaiBaiViet>());
        }
         public ActionResult Baivietthuocloai(string ma)
         {
             List<BaiViet> lst = db.BaiViets.Where(x => x.maLoai == ma).ToList<BaiViet>();
             return View(lst);
         }

        /*public ViewResult BaiVietTheoLoai(String maLoai = "01")
        {
            //kiem tra lai bai viet ton tai hay khong
            LoaiBaiViet l = db.LoaiBaiViets.SingleOrDefault(n => n.maLoai == maLoai);
            if (l == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //truy xuat ds bai viet theo loai, sap xep theo ngay dang
            List<BaiViet> lstBV = db.BaiViets.Where(n => n.maLoai == maLoai).OrderByDescending(n => n.ngayDang).ToList();
            if (lstBV.Count == 0)
            {
                ViewBag.BaiViet = "Khong co bai viet nao thuoc chu de" + l.tenLoai;
            }
            //gan ds loai bai viet
            ViewBag.lstLoaiBV = db.LoaiBaiViets.ToList();
            return View(lstBV);
        }*/
    }

   
}
