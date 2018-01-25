using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TG_SE_101.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var controller = new ProductController();
            var product = new Product
            {
                Id = 1,
                Name = "Notebook"
            };
            controller.Post(product);

            Assert.IsTrue(controller.products.Contains(product));
        }

        [TestMethod()]
        public void GetTestById()
        {
            var controller = new ProductController();
            var product = new Product  
            {
                Id = 1,
                Name = "Laptop",
               
            };
            controller.Post(product);
            var product2 = controller.Get(1);
            Assert.IsTrue(product.Equals(product2));
        }

        [TestMethod()]
        public void PutTest()
        {
            var controller = new ProductController();
            var product = new Product 
            {
                Id = 1,
                Name = "Desktop",
               
            };
            var product2 = new Product
            {
                Id = 1,
                Name = "Mobile",
           
            };
            controller.Post(product);
            controller.Put(1, product2);

            var responseProduct = controller.Get(1);
            Assert.IsTrue(responseProduct.Name == "Mobile");

        }

        [TestMethod()]
        public void DeleteTest()
        {
            var controller = new ProductController();
            var product = new Product
            {
                Id = 1,
                Name = "Mouse",
            };

            controller.Post(product);
            controller.Delete(product.Id);
            Assert.IsTrue(controller.products.Count == 0);

        }
    }
}