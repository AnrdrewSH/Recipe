using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApi.Entities
{
    public class RecipeEntity
    {
        public string Name { get; set; }
        public bool Done { get; set; }
        public int Id { get; set; }

        //public int likes { get; set; }
        //public int stars { get; set; }


    }
}
