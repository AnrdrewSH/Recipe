using System;
using System.Collections.Generic;
using System.Linq;
using RecipeApi;
using RecipeApi.Dbinfrastructure;
using RecipeApi.Dto;
using RecipeApi.Entities;

namespace RecipeApi
{
    public class RecipeRepository : IRecipeRepository
    {
        private RecipeDbContext _context;
        private IUnitOfWork _unitOfWork;
        public RecipeRepository(RecipeDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

        }

        // публичные функции репозитория
        public RecipeDto[] GetAll()
        {
            return _context.Set<RecipeEntity>().ToList()
                .ConvertAll(x => new RecipeDto { Id = x.Id, Name = x.Name, Done = x.Done })
                .ToArray();
        }

        public int Add(RecipeDto recipeDto)
        {
            RecipeEntity newEntity = new RecipeEntity
            {
                Name = recipeDto.Name,
                Done = recipeDto.Done
            };
            _context.Set<RecipeEntity>().Add(newEntity);
            _unitOfWork.Commit();

            return newEntity.Id;
        }

        public void Update(int id, RecipeDto recipeDto)
        {
            RecipeEntity entity = _context.Set<RecipeEntity>().FirstOrDefault(item => item.Id == id);
            entity.Name = recipeDto.Name;
            entity.Done = recipeDto.Done;
            _unitOfWork.Commit();
        }


        // скрытая реализация внутренних сущностей БД
        // сущность БД
        private class Recipe
        {
            public Recipe(int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                CreationDate = DateTime.Now;
            }

            public int Id { get; }
            public string Name { get; set; }
            public bool Done { get; set; }
            public DateTime CreationDate { get; }
        }
        // эмуляция БД
        private static List<Recipe> Database = new List<Recipe>();
        // эмуляция генерации следующего Id БД
        private int GetId()
        {
            int nextId = 1;
            if (Database.Count > 0)
            {
                nextId = Database.Max(x => x.Id) + 1;
            }
            return nextId;
        }
    }
}
