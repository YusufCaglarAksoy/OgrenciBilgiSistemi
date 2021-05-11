using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<E> : Result, IDataResult<E>
    {
        public DataResult(E data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(E data, bool success) : base(success)
        {
            Data = data;
        }
        public E Data { get; }

    }
    
    
}
