namespace Core.Utilities.Results
{
    public class ErrorDataResult<E> : DataResult<E>
    {
        public ErrorDataResult(E data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(E data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
