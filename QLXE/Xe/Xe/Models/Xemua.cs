using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xe.Models
{
    public class Xemua
    {
        CSDLXeEntities db = new CSDLXeEntities();

        public int xMa { get; set; }
        public string xTen { get; set; }
        public  float xGia { get; set; }
        public int xSl { get; set; }
        public float xTT { get { return xGia * xSl; } }

        public Xemua(int xeId)
        {
            xMa = xeId;
            ListXe xe = db.ListXes.Find(xeId);
            xTen = xe.ten;
            xGia = (float)xe.gia;
            xSl = 1;
        }

    }
}