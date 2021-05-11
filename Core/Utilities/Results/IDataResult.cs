namespace Core.Utilities.Results
{
    public interface IDataResult<E>:IResult
    {
        E Data { get; }
    }
}
