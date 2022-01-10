using Bussiness;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.XuLy
{
    public class XuLyLoaiSach
    {
        BussLoaiSach busls = new BussLoaiSach();

        public List<LoaiSach> getDs()
        {
            return busls.LayDanhSachLoaiSach();
        }

        public List<Sach> getSachById( int id)
        {
            return busls.LaySachTheoLoaiSach(id);
        }
    }
}