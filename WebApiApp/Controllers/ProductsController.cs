using WebApiApp.Domain.Models;
using WebApiApp.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProducts")]
        public List<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpPost("AddProduct")]
        public Product AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut("UpdateProduct")]
        public Product UpdateProduct(int id, Product product)
        {
            return _productService.UpdateProduct(id, product);
        }

        [HttpDelete("DeleteProduct")]
        public Product DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }

        [HttpGet("GetCategories")]
        public List<Category> GetCategories()
        {
            return _productService.GetCategories();
        }

        [HttpPost("AddCategory")]
        public Category AddCategory(Category category)
        {
            return _productService.AddCategory(category);
        }

        [HttpPut("UpdateCategory")]
        public Category UpdateCategory(int id, Category category)
        {
            return _productService.UpdateCategory(id, category);
        }

        [HttpDelete("DeleteCategory")]
        public Category DeleteCategory(int id)
        {
            return _productService.DeleteCategory(id);
        }
    }
}
