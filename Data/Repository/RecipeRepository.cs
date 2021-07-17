using Microsoft.EntityFrameworkCore;
using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using System.Collections.Generic;


namespace Recipe_Api.Data.Repository
{
    public class RecipeRepository : IRecipeOutputData
    {
        private readonly AppDbContent appDbContent;
        public RecipeRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Recipe> AllRecipes => appDbContent.Recipe.Include(t => t.Tag);

    }
}
