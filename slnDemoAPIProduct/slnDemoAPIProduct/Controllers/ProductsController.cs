using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using slnDemoAPIProduct.Models;

namespace slnDemoAPIProduct.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Haha soup", Category = "Do an", Price = 1 },
            new Product {Id = 2, Name = "Tiger", Category = "Nuoc giai khat", Price = 10.5M },
            new Product {Id = 3, Name = "Bimbim", Category = "Snack", Price = 12.4M }
        };
        //[Route("getall/{id}")]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        //[Route("find/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        /*
        [Route("create-product/{id}")]
        [HttpPost]
        public IEnumerable<Product> CreateProduct([FromUri]int id)
        {

        }

        [Route("delete-product/{id}")]
        [HttpDelete]
        public IEnumerable<Product> DeleteProduct([FromUri]int id)
        {
            List<Product> lstPro 

        }*/

        [Route("post-product/{id}")]        [HttpPost]        public IEnumerable<Product> CreateProduct([FromUri] int id, Product productnew)        {            List<Product> lstPro = products.ToList<Product>();
            lstPro.Add(productnew);
            return lstPro;

        }        [Route("delete-product/{id}")]

        public IEnumerable<Product> DeleteProduct([FromUri]int id)        {            List<Product> lstPro = products.ToList<Product>();            Product productdel = lstPro.Where(p => p.Id == id).FirstOrDefault<Product>();            lstPro.Remove(productdel);            return lstPro;        }

    }
}
