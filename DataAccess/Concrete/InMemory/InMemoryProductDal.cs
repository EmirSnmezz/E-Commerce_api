using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
            new Product {ProductId = "1", CategoryId = "1", ProductName = "TestUrunAdi", UnitInPrice = 1000, UnitsInStock = 50},
            new Product {ProductId = "2", CategoryId = "4", ProductName = "TestUrunAdi2", UnitInPrice = 3000, UnitsInStock = 58},
            new Product {ProductId = "3", CategoryId = "6", ProductName = "TestUrunAdi3", UnitInPrice = 2400, UnitsInStock = 30},
            new Product {ProductId = "4", CategoryId = "5", ProductName = "TestUrunAdi4", UnitInPrice = 3500, UnitsInStock = 20},
            new Product {ProductId = "5", CategoryId = "8", ProductName = "TestUrunAdi5", UnitInPrice = 7600, UnitsInStock = 40},
            new Product {ProductId = "6", CategoryId = "12", ProductName = "TestUrunAdi6", UnitInPrice = 500, UnitsInStock = 150}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(string categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public ProductDetailDTO GetProductDetails(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product updatedProduct = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.UnitInPrice = product.UnitInPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
            updatedProduct.CategoryId = product.CategoryId;
        }
    }
}
