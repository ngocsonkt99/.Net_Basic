using Bussiness;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.XuLy
{
    public class XuLyLoaiXe
    {
        BussLoaiXe buslx = new BussLoaiXe();

        public List<LoaiXe> getDs()
        {
            return buslx.LayDanhSachLoaiXe();
        }

        public List<Xe> getXeById(int id)
        {
            return buslx.LayXeTheoLoaiXe(id);
        }
    }
}