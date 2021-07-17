using Recipe_Api.Data.Entities;
using System.Collections.Generic;


namespace Recipe_Api.Data.Interfaces
{
    public interface IRecipeOutputData
    {
        IEnumerable<Recipe> AllRecipes { get; }
    }
}
