using Microsoft.VisualStudio.TestTools.UnitTesting;
using TG_SE_101.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace TG_SE_101.Controllers.Tests
{
    [TestClass()]
    public class ManagerSupplierControllerTests
    {
        [TestMethod()]
        public void GetSuppliersTest()
        {
            var controller = new ManagerSupplierController();
            var supplier = new Supplier
            {
                Id = 1453,
                Name = "A Tedarikçisi"
            };
            var manager = new Manager
            {
                Id = 5,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            var managerSupplier = new ManagerSupplier
            {
                Id = 10,
                Manager = manager,
                Supplier = supplier
            };
            controller.Post(managerSupplier);
            var response = controller.GetSuppliers(manager.Id).FirstOrDefault();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 1453);
        }

        [TestMethod()]
        public void GetManagersTest()
        {
            var controller = new ManagerSupplierController();
            var supplier = new Supplier
            {
                Id = 1453,
                Name = "A Tedarikçisi"
            };
            var manager = new Manager
            {
                Id = 5,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            var managerSupplier = new ManagerSupplier
            {
                Id = 10,
                Manager = manager,
                Supplier = supplier
            };
            controller.Post(managerSupplier);
            var response = controller.GetManagers(1453);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Any(x=>x.Id == manager.Id));
      
        }
    }
}