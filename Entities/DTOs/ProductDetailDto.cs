using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //DTO - Data Transformation Object
    public class ProductDetailDto:IDto // IEntity'den miras alamaz. Çünkü bir veritabanı tablosunu tutuyor.Bu yüzden Concrete'deki tüm classlarda kullanılıyor.Burada birden fazla tablonun joini olabilir.
    {                                  // Core'daki IEntity gibi evrensel olmalı.IDto 'da evrensel olmalı. Dto'da ampule tıkla Generate new type'a tıkla. public, interface , Core katmanında Entities altında IDto.cs olarak oluştur.
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
