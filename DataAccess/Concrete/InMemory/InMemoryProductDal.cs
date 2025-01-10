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
            new Product {ProductID = 1, CategoryID = 1, ProductName = "TestUrunAdi", UnitPrice = 1000, UnitsInStock = 50},
            new Product {ProductID = 2, CategoryID = 4, ProductName = "TestUrunAdi2", UnitPrice = 3000, UnitsInStock = 58},
            new Product {ProductID = 3, CategoryID = 6, ProductName = "TestUrunAdi3", UnitPrice = 2400, UnitsInStock = 30},
            new Product {ProductID = 4, CategoryID = 5, ProductName = "TestUrunAdi4", UnitPrice = 3500, UnitsInStock = 20},
            new Product {ProductID = 5, CategoryID = 8, ProductName = "TestUrunAdi5", UnitPrice = 7600, UnitsInStock = 40},
            new Product {ProductID = 6, CategoryID = 1, ProductName = "TestUrunAdi6", UnitPrice = 500, UnitsInStock = 150}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete = _products.SingleOrDefault(x => x.ProductID == product.ProductID);
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

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryID == categoryId).ToList();
        }

        public ProductDetailDTO GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product updatedProduct = _products.SingleOrDefault(x => x.ProductID == product.ProductID);
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
            updatedProduct.CategoryID = product.CategoryID;
        }
    }
}
