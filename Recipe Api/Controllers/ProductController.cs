using Microsoft.AspNetCore.Mvc;
using Recipe_Api.Data.Dto;
using Recipe_Api.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _repositoryProduct;

        public ProductController(IProductRepository iRecipeProduct)
        {
            _repositoryProduct = iRecipeProduct;
        }

        [HttpGet]

        public ProductDto[] Get()
        {
            return _repositoryProduct.GetAllProducts();
        }

        [HttpPost]
        public void Post([FromBody] ProductDto value)
        {
            _repositoryProduct.Add(value);
        }
    }
}
