using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;

namespace TG_SE_101.Controllers
{
    public class ManagerSupplierController : ApiController
    {

        public List<ManagerSupplier> managerSuppliers = new List<ManagerSupplier>();
        // GET api/values
        /// <summary>
        /// Manager(Müdür) Id sine göre Supplier(Tedarikçi) listeleme
        /// </summary>
        /// <param name="id"> Müdür Id si(Manager Id)</param>
        /// <returns>IEnumerable Tedarikçiler (Suppliers)</returns>
        public IEnumerable<Supplier> GetSuppliers(int id)
        {
                return managerSuppliers.Where(x => x.Manager.Id == id)
                    .Select(x => x.Supplier).ToList();
        }
        /// <summary>
        /// Supplier(Tedarikçi) Id sine göre Managers(Müdürler) listeleme
        /// </summary>
        /// <param name="id"> Tedarikçi Id si(Supplier Id)</param>
        /// <returns>IEnumerable Müdürler (Menagers)</returns>
        public IEnumerable<Manager> GetManagers(int id)
        {
            return managerSuppliers.Where(x => x.Supplier.Id == id)
                .Select(x => x.Manager).ToList();
        }
        public void Post([FromBody]ManagerSupplier managerSupplier)
        {
            managerSuppliers.Add(managerSupplier);
        }
    }
}
