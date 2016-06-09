using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {ID = 1, Name = "Halo", Category = "Games", Price = 60 },
            new Product {ID = 1, Name = "Bread", Category = "Foog", Price = 4.80M },
            new Product {ID = 1, Name = "Television", Category = "Electronics", Price = 2000 }
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
