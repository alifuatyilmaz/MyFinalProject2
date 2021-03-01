using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult // IResult'ta zeten mesaj ve işlem sonucu mevcut.
    {
        T Data { get; } // Mesaj, işlem sonucu ve datayı içerecek.
    }
}
