namespace Core.Utilities.Messages.Results.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message): base(true, message) {}

        public SuccessResult() : base(false) {}
    }
}
