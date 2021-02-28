﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess // Core katmanı diğer katmanları referans almaz.
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()// T:class,IEntity diğer 3 interface için kullanılacakları tipleri belirliyor.Referans tipinde ve Entity tipinde olacaklar.
    {                                                                //Bunları tanımlamamızın amacı sadece veritabanı nesnelerini kullanabilmek için.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// üç interface'de aynı elemanları kullanacağı için ortak bir interface oluşturalım. T tipinde.
                                                             // ProductManager.cs'deki "public List<Product> GetAll()" metodundaki gibi filtreler yazmamızı sağlıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
//core katmanında evrensel olarak kullanacağımız kodları koyuyoruz.