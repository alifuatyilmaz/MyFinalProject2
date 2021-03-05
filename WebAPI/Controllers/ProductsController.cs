using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //Controllers klasörüne sağ tık Add->Controller'ı seç. API'yi seç API-Controller-Empty seç.Sonra ekle.
    //Postman download et. Veriyi JSON ile düzenli hale getirebilirsin.
    [Route("api/[controller]")] // Bu siteyi yaparken insanlar bize nasıl ulaşsın onu belirliyor. (localhost:44314/api/products) bu sayfayı çağırır.
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /*
        [HttpGet]
        public string Get()
        {
            return "Merhaba";
        }
        */
        /*
        [HttpGet]
        public List<Product> Get() // WebAPI üzerine sağ tık Add->Referances ekle.ConsoleUI dışındakileri ver.
        {
            return new List<Product>
            {
                new Product{ProductId=1,ProductName="Elma"},
                new Product{ProductId=2,ProductName="Armut" },
            };
        }
        */
        /*
        [HttpGet]
        public string Get()
        {
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
            return result.Message;
        }
        */
        /*
        [HttpGet]
        public List<Product> Get() // Ürünleri listeler
        {
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
            return result.Data;
        }
        */
        
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain --
            var result =  _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product) 
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}