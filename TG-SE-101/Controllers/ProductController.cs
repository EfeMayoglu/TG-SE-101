using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TG_SE_101.Controllers
{
    public class ProductController : ApiController
    {
        public List<Product> products = new List<Product>();
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        public void Post([FromBody]Product product)
        {
            products.Add(product);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Product product)
        {
            var product2 = products.FirstOrDefault(x => x.Id == id);
            if (product2 != null)
            {
                product2.Name = product.Name;

            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}