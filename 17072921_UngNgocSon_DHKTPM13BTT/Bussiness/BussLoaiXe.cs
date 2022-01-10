using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class BussLoaiXe
    {
        XeContext db = new XeContext();

        public List<LoaiXe> LayDanhSachLoaiXe()
        {
            return db.LoaiXees.ToList();
        }

        public List<Xe> LayXeTheoLoaiXe(int id)
        {
            return db.Xees.Where(x => x.LoaiXeId == id).ToList();
        }
    }
}
