using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjData;
using WebProject.Models;


namespace WebProject.Controllers
{
    public class RecipesController : Controller
    {
        // GET: Recipes
        private Recipes recipe = new Recipes();
        public ActionResult Index()
        {
            return View(recipe.GetAllRecipes());
        }

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe rep_new)
        {
            if (ModelState.IsValid)
            {
                recipe.AddRecipe(rep_new);
                return RedirectToAction("Index");
            }
            return View(rep_new);
        }

        public ActionResult Edit(int Id)
        {
            Recipe redit = recipe.GetRecipeById(Id);
            return View(redit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Content,WriterId")] Recipe repedit)
        {
            if (ModelState.IsValid)
            {
                recipe.Edit(repedit);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Details(int Id)
        {
            Recipe r = recipe.GetRecipeById(Id);
            return View(r);
        }

        public ActionResult Delete(int id)
        {
            Recipe rep = recipe.GetRecipeById(id);
            return View(rep);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe redel = recipe.GetRecipeById(id);
            recipe.Remove(redel);
            return RedirectToAction("Index");
        }
    }
}