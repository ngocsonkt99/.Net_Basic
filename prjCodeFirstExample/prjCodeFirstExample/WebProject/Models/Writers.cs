using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prjData;
using prjBusiness;

namespace WebProject.Models
{
    public class Writers
    {
        private KitchenControl kitchen = new KitchenControl();

        public ICollection<Writer> getWriter()
        {
            return kitchen.GetWriters(); //tra ve list wrieter
        }

        public Writer Add(Writer writer)
        {
            return kitchen.AddWriter(writer);
        }

        public Writer GetwriterById(int id)
        {
            return kitchen.GetWriterById(id);
        }

        public void Remove(Writer wr)
        {
            kitchen.RemoveWriter(wr);
        }

        public void Edit(Writer w)
        {
            kitchen.Edit(w);
        }
    }
}