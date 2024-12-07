using Core.Utilities.Messages.Results.Result.Abstract;

namespace Core.Utilities.Messages.Results.Result.Concrete
{
    public class Result : IResult
    {
        public string Message { get; }
        public bool IsSuccess { get;}

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
        }
    }
}
