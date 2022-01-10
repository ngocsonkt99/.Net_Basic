using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class XeContext : DbContext
    {
        public XeContext() : base("SachContext") { }

        public DbSet<Xe> Xees { set; get; }
        public DbSet<LoaiXe> LoaiXees { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
