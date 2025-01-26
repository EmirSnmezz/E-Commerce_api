using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Business;
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
        private readonly ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        [ValidationAspect(typeof(ProductValidations))]
        public IResult Add(Product product)
        {   
            IResult result = BusinessRules.Run(CheckIfProductCountOfCategoryCorrect(product.CategoryID), CheckIfProductNameExist(product.ProductName), CheckIfCategoryLimitExceded());
            if (result != null)
            {
                return result;
            }
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
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<ProductDetailDTO> GetAllDetail(int id)
        {
            return new SuccessDataResult<ProductDetailDTO>(_productDal.GetProductDetails(id), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.CategoryID == categoryId), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max), Messages.ProductsListedSuccessfully);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductID == id), Messages.ProductsListedSuccessfully);
        }

        #region Business Rules Control Methods
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId) // private çünkü bu methodun sadece bu classın içerisinde kullanılmasını istiyoruz. Eğer ki ben bunu farklı managerlarda kullanabilirim dersek sakın bunu public yapmayacağız. Öyle bir durumda bu bir servis olmuş olur bunu interface'e yazıp öyle implement etmemiz gerekecektir.
        {
            List<Product> productsByCategoryId = _productDal.GetAll(x => x.CategoryID == categoryId);
            if (productsByCategoryId.Count() < 10)
            {
                return new SuccessResult(Messages.ProductAddedSuccessfully);
            }
            return new ErrorResult(Messages.ProductCountOfCategoryError);
        }

        private IResult CheckIfProductNameExist(string productName)
        {
            bool getProductByName = _productDal.GetAll(x => x.ProductName == productName).Any();

            if (!getProductByName)
            {
                return new SuccessResult();
            }

            return new ErrorResult(Messages.ProductNameAlReadyExistError);
        }

        private IResult CheckIfCategoryLimitExceded()
        {
            int result = _categoryService.GetAll().Result.Distinct().Count();

            if (result < 15)
            {
                return new SuccessResult();
            }

            return new ErrorResult(Messages.CatergoryCountError);
        }
        #endregion
    }
}
