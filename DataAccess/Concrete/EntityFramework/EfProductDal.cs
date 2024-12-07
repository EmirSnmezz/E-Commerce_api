using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {
        public ProductDetailDTO GetProductDetails(string id)
        {
            using (var db = new NorthwindDbContext()) 
            {
                ProductDetailDTO result = (from p in db.Products
                                          join c in db.Categories
                                          on p.CategoryId equals c.CategoryId
                                          select new ProductDetailDTO
                                          {
                                              CategoryName = c.CategoryName,
                                              ProductId = (p.ProductId),
                                              ProductName = p.ProductName,
                                              UnitsInStock = p.UnitsInStock
                                          }).FirstOrDefault();

                return result;
            }
        }
    }
}
