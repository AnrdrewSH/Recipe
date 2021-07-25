using Recipe_Api.Data.Dto;
using Recipe_Api.Data.Entities;
using Recipe_Api.Data.Interfaces;
using Recipe_Api.Dblnfrastructure;
using System.Linq;

namespace Recipe_Api.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext _context;
        private IUnitOfWork _unitOfWork;
        public ProductRepository(AppDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

        }
        public ProductDto[] GetAllProducts()
        {
            return _context.Set<Product>().ToList()
                .ConvertAll(x => new ProductDto { ProductId = x.ProductId, ProductName = x.ProductName })
                .ToArray();
        }
        public int Add(ProductDto productDto)
        {
            Product newProduct = new Product
            {
                ProductName = productDto.ProductName,
            };
            _context.Set<Product>().Add(newProduct);
            _unitOfWork.Commit();

            return newProduct.ProductId;
        }
    }
}
