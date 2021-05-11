namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool succes, string message):this(succes)
        {
            Message = message;
        }

        public Result(bool succes)
        {
            Success = succes;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
