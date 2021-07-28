using Recipe_Api.Data.Dto;

namespace Recipe_Api.Data.Interfaces
{
    public interface IProductRepository
    {
        ProductDto[] GetAllProducts();
        int Add(ProductDto productDto);
    }
}
