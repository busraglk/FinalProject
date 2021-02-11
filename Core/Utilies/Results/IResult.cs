using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        // get : sadece okunabilir.
        // set : yazmak için kullanılır.
        bool Success { get; }
        string Message { get; }
    }
}
