using System.Collections.Generic;


namespace Recipe_Api.Data.Entities
{
    public class IngredientHeader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
