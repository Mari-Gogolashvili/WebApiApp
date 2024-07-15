using WebApiApp.Domain.Models;

namespace WebApiApp.Services.Abstractions
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product AddProduct(Product product);
        public Product UpdateProduct(int id, Product product);
        public Product DeleteProduct(int id);

        public List<Category> GetCategories();
        public Category AddCategory(Category category);
        public Category UpdateCategory(int id, Category category);
        public Category DeleteCategory(int id);
    }
}
