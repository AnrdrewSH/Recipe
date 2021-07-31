using Recipe_Api.Data.Dto;
using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using Recipe_Api.Dblnfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Api.Data.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private AppDbContext _context;
        private IUnitOfWork _unitOfWork;
        public RecipeRepository(AppDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

        }
        public RecipeDto[] GetAllRecipes()
        {
            return _context.Set<Recipe>().ToList()
                .ConvertAll(x => new RecipeDto { Id = x.Id, Name = x.Name })
                .ToArray();
        }
        public int Add(RecipeDto RecipeDto)
        {
            Recipe newRecipe = new Recipe
            {
                Name = RecipeDto.Name,
            };
            _context.Set<Recipe>().Add(newRecipe);
            _unitOfWork.Commit();

            return newRecipe.Id;
        }
    }
}
