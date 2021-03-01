using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); // Business katmanı her iki katmandan da referans almalı.Her iki katmanın bilgilerini kullanıyor. T burada <List<Product>>'ı temsil ediyor.
        IDataResult<List<Product>> GetAllByCategoryId(int id); // CategoryId'sine göre tüm listeyi getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails(); // En son yazılacak yer.
        IDataResult<Product> GetById(int productId); // Tek başına bir ürün döndürüyor.
        IResult Add(Product product); // void olan yerlerde IResult diyeceğiz .Core katmanı altında Result klasörü içinde IResult içinde tanımlanmış
        IResult Update(Product product);

        //RESTFUL --> HTTP --> 
    }
}
