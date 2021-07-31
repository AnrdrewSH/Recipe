//using Microsoft.AspNetCore.Mvc;
//using Recipe_Api.Data.Dto;
//using Recipe_Api.Data.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Recipe_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RecipeController : ControllerBase
//    {
//        private readonly IRecipeRepository _repositoryRecipe;

//        public RecipeController(IRecipeRepository iRecipe)
//        {
//            _repositoryRecipe = iRecipe;
//        }

//        [HttpGet]

//        public RecipeDto[] Get()
//        {
//            return _repositoryRecipe.GetAllRecipes();
//        }

//        [HttpPost]
//        public void Post([FromBody] RecipeDto value)
//        {
//            _repositoryRecipe.Add(value);
//        }
//    }
//}
