using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        //ClassLibrary : Birbiriyle ilişkili classları koyduğumuz kütüphaneye denir.(Business, DataAccess ve Entities ClassLibrary olarak)
        //Abstract klasörlerine soyut nesneleri koyacağız.Bunlar bizim referans tutucularımız olacak.Yani interface'leri, abstract nesneleri ve base classları bu klasörlerin içine koyacağız.
        //Concrete klasörlerine somut nesneleri yani gerçek işi yapan classları koyacağız.
        //Burada tüm katmanları kullanacağımız için hepsinden referans alacağız.ConsoleUI sağ tık->Project Reference'dan hepsini seç.
        static void Main(string[] args)
        {
            //Data Transformation Object
            ProductTest();
            //IoC 
            //CategoryTest();

            /*
            ProductManager productManager = new ProductManager(new EfProductDal()); // Burada InMemoryProductDal yerine EfProductDal kullan(Sisteminin değiştiğini düşün).
            foreach (var product in productManager.GetByUnitPrice(50, 100)) //UnitPrice'ı 50 ile 100 arası olanları listeler.
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager.GetAllByCategoryId(2)) // CategoryId'si 2 olanları listeler.
            {
                Console.WriteLine(product.ProductName);
            }
            */
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal() // Burada InMemoryProductDal yerine EfProductDal kullan(Sisteminin değiştiğini düşün).
                , new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
