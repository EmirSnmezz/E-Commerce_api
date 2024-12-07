
using Core.Utilities.Messages.Results.Result.Abstract;
using Entity.Abstract;

namespace Core.Utilities.Messages.Results.DataResult.Abstract
{
    public interface IDataResult<T> : IResult
     {
        T Result { get;}
    }
}
