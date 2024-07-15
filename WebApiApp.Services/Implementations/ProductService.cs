using Microsoft.EntityFrameworkCore;
using WebApiApp.Domain.Models;
using WebApiApp.ProjectDB;
using WebApiApp.Services.Abstractions;


namespace WebApiApp.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext;

        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();

            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var productInDb = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);

            if (productInDb != null)
            {
                productInDb.Price = product.Price;
                productInDb.Name = product.Name;
                productInDb.CategoryId = product.CategoryId;
            }
            _dbContext.Entry(productInDb).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return productInDb;
        }

        public Product DeleteProduct(int id)
        {
            var productInDb = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);

            if (productInDb != null)
            {
                _dbContext.Products.Remove(productInDb);
            }

            _dbContext.SaveChanges();

            return productInDb;
        }
        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);

            _dbContext.SaveChanges();

            return category;
        }

        public Category UpdateCategory(int id, Category category)
        {
            var categoryInDb = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);

            if (categoryInDb != null)
            {
                categoryInDb.CategoryId = category.CategoryId;
                categoryInDb.Name = category.Name;
                categoryInDb.Description = category.Description;
            }
            _dbContext.Entry(categoryInDb).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return categoryInDb;
        }

        public Category DeleteCategory(int id)
        {
            var categoryInDb = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);

            if (categoryInDb != null)
            {
                _dbContext.Categories.Remove(categoryInDb);
            }

            _dbContext.SaveChanges();

            return categoryInDb;
        }
    }
}
