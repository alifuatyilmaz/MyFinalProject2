using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T> // Bu kod kısmını komple kopyala ErrorDataResult içine yapıştır.
    {
        public SuccessDataResult(T data, string message):base(data,true,message) // Tüm verileri ve mesajları göndermek için
        {

        }

        public SuccessDataResult(T data):base(data,true) //Mesaj yollamayabilir. Sadece datayı yollayabilir.
        {

        }
        
        public SuccessDataResult(string message):base(default,true,message) // Sadece mesaj yollamak için.
        {

        }

        public SuccessDataResult():base(default,true) // Hiç birşey vermek istemiyoruz. Sadece default değeri veriyoruz.
        {
                
        }
    }
}
