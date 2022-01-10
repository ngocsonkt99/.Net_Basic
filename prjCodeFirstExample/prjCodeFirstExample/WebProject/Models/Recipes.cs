using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prjData;
using prjBusiness;
namespace WebProject.Models
{
    public class Recipes
    {
        private KitchenControl kitchen = new KitchenControl();

        public ICollection<Recipe> GetAllRecipes()
        {
            return kitchen.GetRecipes(); //tra ve list recipe
        }

        public Recipe AddRecipe(Recipe rep)
        {
            kitchen.AddRecipe(rep);
            return rep;
        }

        public Recipe GetRecipeById(int id)
        {
            return kitchen.GetRecipeId(id);
        }

        public void Remove(Recipe re)
        {
            kitchen.RemoveReciper(re);
        }

        public void Edit(Recipe r)
        {
            kitchen.Edit(r);
        }
    }
}