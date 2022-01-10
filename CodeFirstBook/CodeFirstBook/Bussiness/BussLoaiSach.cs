using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;
namespace Bussiness
{
    
    public class BussLoaiSach
    {
        SachContext db = new SachContext();

        public List<LoaiSach> LayDanhSachLoaiSach()
        {
            return db.LoaiSaches.ToList();
        }

        public List<Sach> LaySachTheoLoaiSach(int id)
        {
            return db.Saches.Where(x => x.LoaiSachId == id).ToList();
        }


    }
}
