namespace Core.Utilities.Messages.Results.Result.Abstract
{
    public interface IResult
    {
        public string Message { get;}
        public bool IsSuccess { get; }
    }
}
