using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SachContext:DbContext
    {
        public SachContext() : base("SachContext") { }

        public DbSet<Sach> Saches { set; get; }
        public DbSet<LoaiSach> LoaiSaches { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
