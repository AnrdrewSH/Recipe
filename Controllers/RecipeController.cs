using Microsoft.AspNetCore.Mvc;
using Recipe_Api.Data.Interfaces;


namespace Recipe_Api.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeStep _recipeStep;

        public RecipeController(IRecipeStep iRecipeStep)
        {
            _recipeStep = iRecipeStep;
        }

        public ViewResult List()
        {
            var steps = _recipeStep.AllSteps;
            return View(steps);
        }
    }
}
