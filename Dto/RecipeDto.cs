using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApi.Dto
{
    public class RecipeDto
    {
        public string Name { get; set; }
        public bool Done { get; set; }
        public int Id { get; set; }
    }
}
