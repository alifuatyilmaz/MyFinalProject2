using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult // İşlem sonucu
    {
        bool Success { get; } // Sadece okunabilir olacak. Başarılı mı başarısız mı olduğunu belirtecek.
        string Message { get; } // Kullanıcıya mesaj gönderecek.Başarılı veya başarısız olduğunda.

    }
}
