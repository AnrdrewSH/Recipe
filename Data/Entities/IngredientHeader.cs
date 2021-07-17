using System.Collections.Generic;


namespace Recipe_Api.Data.Entities
{
    public class IngredientHeader
    {
        public int HeaderId { get; set; }
        public string NameHeader { get; set; }
        public List<Product> Products { get; set; }
    }
}
