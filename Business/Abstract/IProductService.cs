﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); // Business katmanı her iki katmandan da referans almalı.Her iki katmanın bilgilerini kullanıyor.
        IDataResult<List<Product>> GetAllByCategoryId(int id); // CategoryId'sine göre tüm listeyi getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);

        //RESTFUL --> HTTP --> 
    }
}