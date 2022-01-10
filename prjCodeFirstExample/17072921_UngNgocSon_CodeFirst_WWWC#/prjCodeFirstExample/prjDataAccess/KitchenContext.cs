using prjData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjDataAccess
{
    public class KitchenContext:DbContext
    {
        public KitchenContext() : base("KitchenContext") { }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

   
}
