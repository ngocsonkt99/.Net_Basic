using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjData;
using prjDataAccess;

namespace prjBusiness
{
    public class KitchenControl
    {
        private KitchenContext KitchenDB = new KitchenContext();
        public Writer AddWriter(Writer writer)
        {
            KitchenDB.Writers.Add(writer);
            KitchenDB.SaveChanges();
            return writer;
        }

        public void RemoveWriter(Writer writer)
        {
            KitchenDB.Writers.Remove(writer);
            KitchenDB.SaveChanges();
        }

        public ICollection<Writer> GetWriters()
        {   
            return KitchenDB.Writers.ToList<Writer>();
        }

        public Writer GetWriterById(int id)
        {
            Writer w = KitchenDB.Writers.Where(obj => obj.Id == id).FirstOrDefault();
            return w;
        }

        public void Edit(Writer w)
        {
            KitchenDB.Entry(w).State = EntityState.Modified;
            KitchenDB.SaveChanges();
        }





      
       
        //----------------------------------------------
        public ICollection<Recipe> GetRecipes()
        {
            return KitchenDB.Recipe.ToList<Recipe>();
        }

        public Recipe GetRecipeId(int id)
        {
            Recipe rep = KitchenDB.Recipe.Find(id);
            return rep;
        }
        public void RemoveReciper(Recipe redel)
        {
            KitchenDB.Recipe.Remove(redel);
            KitchenDB.SaveChanges();
        }
        public void Edit(Recipe repedit)
        {
            KitchenDB.Entry(repedit).State = EntityState.Modified;
            KitchenDB.SaveChanges();
        }

        public Recipe AddRecipe(Recipe re)
        {
            KitchenDB.Recipe.Add(re);
            KitchenDB.SaveChanges();
            return re;
        }

    }
}
