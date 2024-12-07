using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Messages.Results.DataResult.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T result) : base(result, false) {}

        public ErrorDataResult(T result, string message) : base(result, false, message) { }

        public ErrorDataResult(string message): (default, message) {}

        public ErrorDataResult(): base(default, false) {}
    }
}
