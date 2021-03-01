using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T> //Success yazan herşeyi error olarak, true'ları false yap.
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) // Tüm verileri ve mesajları göndermek için
        {

        }

        public ErrorDataResult(T data) : base(data, false) //Mesaj yollamayabilir. Sadece datayı yollayabilir.
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) // Sadece mesaj yollamak için.
        {

        }

        public ErrorDataResult() : base(default, false) // Hiç birşey vermek istemiyoruz. Sadece default değeri veriyoruz.
        {

        }
    }
}
