using Business.Abstract;
using Core.Utilities.Messages.Results.DataResult.Abstract;
using Core.Utilities.Messages.Results.DataResult.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll().ToList());
        }

        public IDataResult<Category> GetById(int id)
        {
            var result = _categoryDal.Get( category => Convert.ToInt32(category.CategoryId) == id);
            return new SuccessDataResult<Category>(result);
        }
    }
}
