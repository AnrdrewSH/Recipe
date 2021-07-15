using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApi.Dto;

namespace RecipeApi
{
    public interface IRecipeRepository
    {
        RecipeDto[] GetAll();
        int Add(RecipeDto recipeDto);
        void Update(int id, RecipeDto recipeDto);
    }
}
