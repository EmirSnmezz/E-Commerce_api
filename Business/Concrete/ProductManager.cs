using Business.Abstract;
using Core.Utilities.Messages.Constants;
using Core.Utilities.Messages.Results.DataResult.Abstract;
using Core.Utilities.Messages.Results.DataResult.Concrete;
using Core.Utilities.Messages.Results.Result.Abstract;
using Core.Utilities.Messages.Results.Result.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }
        public IResult Add(Product product)
        {
            if(product.ProductName.Length <= 2)
                return new ErrorResult(Messages.ProductAddedError);
            
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAddedSuccessfully);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdatedSuccessfully);
        }

        public IResult Delete(Product product)
        {

            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeletedSuccessfully);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if(DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(default, Messages.MaintenanceTimeError);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<ProductDetailDTO> GetAllDetail(int id)
        {
            return new SuccessDataResult<ProductDetailDTO>(_productDal.GetProductDetails(id), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x=> x.CategoryID == categoryId), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max), Messages.ProductsListedSuccessfully);
        }
    }
}
