

using Core.Utilities.Messages.Results.DataResult.Abstract;
using Entity.Abstract;

namespace Core.Utilities.Messages.Results.DataResult.Concrete
{
    public class DataResult<T> : Result.Concrete.Result, IDataResult<T>
    {
        public T Result{ get; }


        public DataResult(T result, bool isSuccess, string message) : base(isSuccess, message) => Result = result;
        public DataResult(T result, bool isSuccess) : base(isSuccess) =>  Result = result;

    }
}
