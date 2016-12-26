using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProductsApp.Models;

using System.Net;
using System;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
     
        
        // по keyword возвращает обект типа Product , который я хочу передать клиенту


       
        [HttpGet]
        public Product GetProduct(string key)
        {

            
            var product = ModelProducts.GetProductByKeyword(key);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
            
        }



         

    }
}