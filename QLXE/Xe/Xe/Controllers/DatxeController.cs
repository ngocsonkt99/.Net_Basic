using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xe.Models;

namespace Xe.Controllers
{
    public class DatxeController : Controller
    {
        // GET: Datxe
        CSDLXeEntities db = new CSDLXeEntities();
        public ActionResult Datxemua()
        {
            if (Session["Mua"] == null)
            {
                return RedirectToAction("Index", "ListXes");
            }
            List<Xemua> lstxe = GetXe();
            ViewBag.Tien = lstxe.Sum(x => x.xTT);
           // ViewBag.thongbao = this TempData["Thongbao"];
            return View(lstxe);
        }
        public List<Xemua> GetXe()
        {
            List<Xemua> lstXe = Session["Mua"] as List<Xemua>;
            if(lstXe == null)
            {
                lstXe = new List<Xemua>();
                Session["Mua"] = lstXe;
            }
            return lstXe;
        }

        public ActionResult Addcar(int xeid, string strUrl)
        {
            ListXe xe = db.ListXes.Find(xeid);
            if (xe == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Xemua> lstxe = GetXe();

            Xemua x = lstxe.Find(n => n.xMa == xeid);
            if (x == null)
            {
                x = new Xemua(xeid);
                lstxe.Add(x);
                return Redirect(strUrl);
            }
            else
                x.xSl++;
            return Redirect(strUrl);
        }

        private int tongSL()
        {
         
                int itongSL = 0;
                List<Xemua> lstxe = Session["Mua"] as List<Xemua>;
                if (lstxe != null)
                {
                    itongSL = lstxe.Sum(n => n.xSl);
                }
                return itongSL;
            
        }
        private float tongtien()
        {
            float itongTT = 0;
            List<Xemua> lstxe = Session["Mua"] as List<Xemua>;
            if (lstxe != null)
            {
                itongTT = lstxe.Sum(n => n.xTT);
            }
            return itongTT;
        }

        public ActionResult XemuaPatial()
        {
            if(tongSL()== 0)
            {
                return PartialView();
            }
            ViewBag.TongSL = tongSL();
            ViewBag.TongTT = tongtien();
            return PartialView();
        }

        public ActionResult Capnhatxemua(int xeid, FormCollection f)
        {
            //kiem tra xem da co chua ?
            ListXe x = db.ListXes.Find(xeid);
            if (x == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //lay xe mua tu session da luu
            List<Xemua> lstXe = GetXe();
            Xemua m = lstXe.FirstOrDefault(n => n.xMa == xeid);
            //kie tra m la xe mua co trong ds xe dat mua?
            if(m != null)
            {
                m.xSl = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("Datxemua");
        }
        public ActionResult Xoaxemua(int xeid)
        {
            //tim xe can xoa theo xeid
            ListXe x = db.ListXes.Find(xeid);
            if (x == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<Xemua> lstXe = GetXe();
            Xemua m = lstXe.FirstOrDefault(n => n.xMa == xeid);
            if(m!= null)
            {
                lstXe.RemoveAll(n => n.xMa == xeid);
            }
            if(lstXe.Count == 0)
            {
                return RedirectToAction("Index", "ListXes");
            }
            return RedirectToAction("Datxemua");
        }
     
    }
}