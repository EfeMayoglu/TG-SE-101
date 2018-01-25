using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TG_SE_101.Controllers
{
    public class SupplierController : ApiController
    {
        public List<Supplier> suppliers = new List<Supplier>();
        // GET api/values
        public IEnumerable<Supplier> Get()
        {
            return suppliers;
        }

        // GET api/values/5
        public Supplier Get(int id)
        {
            return suppliers.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        public void Post([FromBody]Supplier supplier)
        {
            suppliers.Add(supplier);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Supplier supplier)
        {
            var supplier2 = suppliers.FirstOrDefault(x => x.Id == id);
            if (supplier2 != null)
            {
                supplier2.Name = supplier.Name;

            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var supplier = suppliers.FirstOrDefault(x => x.Id == id);
            if (supplier != null)
            {
                suppliers.Remove(supplier);
            }
        }
    }
}
