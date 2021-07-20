//using Microsoft.EntityFrameworkCore;
//using Recipe_Api.Data.Entities;
//using Recipe_Api.Data.Interfaces;
//using System.Collections.Generic;


//namespace Recipe_Api.Data.Repository
//{
//    public class RecipeRepository : IRecipeOutputData
//    {
//        private readonly AppDbContext appDbContext;
//        public RecipeRepository(AppDbContext appDbContext)
//        {
//            this.appDbContext = appDbContext;
//        }
//        public IEnumerable<Recipe> AllRecipes => appDbContext.Recipe.Include(t => t.Tag);

//    }
//}
