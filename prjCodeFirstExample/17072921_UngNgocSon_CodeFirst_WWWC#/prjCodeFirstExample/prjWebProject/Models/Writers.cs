using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prjModel;
using prjBusiness;

namespace prjWebProject.Models
{
    public class Writers
    {
        private KitchenControll kitchenct = new KitchenControll();

        public ICollection<Writer> getWriter()
        {
            return kitchenct.GetWriters(); //return list writer
        }

        public Writer Add(Writer writer)
        {
            return kitchenct.AddWriter(writer);
        }

        
    }
}