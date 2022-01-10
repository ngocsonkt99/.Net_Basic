using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using prjDemoEF.Models;

namespace prjDemoEF.Controllers
{
    public class NguoiDungController : Controller
    {
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult DangKy(TaiKhoan _taiKhoan)
        {
            if (ModelState.IsValid)
            {
                //using (var db = new Personal_FSoftEntities())
                var db = new Personal_FSoftEntities();
                    var check = db.TaiKhoans.FirstOrDefault(s => s.email == _taiKhoan.email);
                if (check == null)
                {
                    //_taiKhoan.matKhau = GetMD5(_taiKhoan.matKhau);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.TaiKhoans.Add(_taiKhoan);
                    db.SaveChanges();
                    return RedirectToAction("Index", "BaiViets");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }


            }
            return View();

        }
        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        // GET: NguoiDung
        [HttpPost]
        public ActionResult DangNhap(string strURL, FormCollection f)
        {
            string username = f["txtUser"].ToString();
            string password = f["txtPass"].ToString();
            if (CheckUser(username, password))
            {
                //tao session
                Session["maTaiKhoan"] = username;
                HttpCookie ck = new HttpCookie("myCookies");
                ck["name"] = username;
                //tao cookies
                Response.Cookies.Add(ck);
                ck.Expires = DateTime.Now.AddDays(3);//gioi han tg 3 day
                return Redirect(strURL);
            }
            ViewBag.ThongBao = "Tên tk hoa pass hk dung";
            return Redirect(strURL);
        }
        public bool CheckUser(string username, string password)
        {
            using (var db = new Personal_FSoftEntities())
            {
                var kq = db.TaiKhoans.Where(x => x.maTaiKhoan == username && x.matKhau == password).ToList<TaiKhoan>();
                if (kq.Count() > 0)
                    return true;
                return false;
            }
        }

        public ActionResult DangXuat(string strURL)
        {
            //xoa session
            Session.Abandon();
            //xoa cookies
            if (Request.Cookies["myCookies"] != null)
            {
                HttpCookie myCookie = new HttpCookie("myCookies");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
            return Redirect(strURL);
        }

        public ActionResult DoiMatKhau()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoiMatKhau(string username, string strURL, FormCollection f)
        {
            using(var db=new Personal_FSoftEntities())
            {
                string oldPass = f["txtOld"].ToString();
                string newPass = f["txtNew"].ToString();
                TaiKhoan tk = db.TaiKhoans.Where(x => x.maTaiKhoan == username && x.matKhau == oldPass).FirstOrDefault<TaiKhoan>();
                if(tk != null)
                {
                    tk.matKhau = newPass;
                    db.SaveChanges();
                    ViewBag.ThongBao = "Doi pass thanh cong";
                    return Redirect(strURL);
                }
                ViewBag.ThongBao = "Thong tin chua dung";
                return Redirect(strURL);
            }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}