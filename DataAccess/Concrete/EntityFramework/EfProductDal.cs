using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EntityRepositoryBase<Product>, IProductDal
    {
    }
}
