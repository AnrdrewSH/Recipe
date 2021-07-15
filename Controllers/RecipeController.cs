using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApi;
using RecipeApi.Dto;


namespace RecipeApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private IRecipeRepository _repository;
        public RecipeController(IRecipeRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public RecipeDto[] Get()
        {
            return _repository.GetAll();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] RecipeDto value)
        {
            _repository.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RecipeDto value)
        {
            _repository.Update(id, value);
        }
    }
}
