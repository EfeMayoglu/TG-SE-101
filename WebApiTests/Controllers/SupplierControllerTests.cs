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
    public class SupplierControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var controller = new SupplierController();
            var supplier = new Supplier
            {
                Id = 1,
                Name = "A Tedarikçisi"
            };
            controller.Post(supplier);

            Assert.IsTrue(controller.suppliers.Contains(supplier));
        }

        [TestMethod()]
        public void GetTestById()
        {
            var controller = new SupplierController();
            var supplier = new Supplier
            {
                Id = 1,
                Name = "J Tedarikçisi",
            };

            controller.Post(supplier);
            var supplier2 = controller.Get(1);
            Assert.IsTrue(supplier.Equals(supplier2));
        }

        [TestMethod()]
        public void PutTest()
        {
            var controller = new SupplierController();
            var supplier = new Supplier
            {
                Id = 1,
                Name = "X Tedarikçisi",

            };
            var supplier2 = new Supplier
            {
                Id = 1,
                Name = "Y Tedarikçisi",

            };
            controller.Post(supplier);
            controller.Put(1, supplier2);

            var responseProduct = controller.Get(1);
            Assert.IsTrue(responseProduct.Name == supplier2.Name);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            var controller = new SupplierController();
            var supplier = new Supplier
            {
                Id = 1,
                Name = "Mouse",
            };

            controller.Post(supplier);
            controller.Delete(supplier.Id);
            Assert.IsTrue(controller.suppliers.Count == 0);

        }
    }
}