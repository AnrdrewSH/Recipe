using Microsoft.AspNetCore.Mvc;
using Recipe_Api.Arrays;
using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;


namespace Recipe_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {

        private readonly IRecipeStep _recipeStep;

        public RecipeController(IRecipeStep iRecipeStep)
        {
            _recipeStep = iRecipeStep;
        }

        [HttpGet]

        public StepArray[] Get()
        {
            return _recipeStep.AllSteps();
        }
    }
}
