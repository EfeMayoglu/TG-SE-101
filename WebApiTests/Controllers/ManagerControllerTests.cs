using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TG_SE_101.Controllers;

namespace TG_SE_101.Controllers.Tests
{
    [TestClass()]
    public class ManagerControllerTests
    {
        [TestMethod()]
        public void CheckLoginTest()
        {
            var controller = new ManagerController();
            var manager = new Manager
            {
                Id = 1,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            controller.Post(manager);

            var check = controller.CheckLogin("efemayoglu", "1234");
            Assert.IsNotNull(check);
        }
        [TestMethod()]
        public void GetTest()
        {
            var controller = new ManagerController();
            var manager = new Manager
            {
                Id = 1,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            controller.Post(manager);

            Assert.IsTrue(controller.managers.Contains(manager));
        }

        [TestMethod()]
        public void GetTestById()
        {
            var controller = new ManagerController();
            var manager = new Manager
            {
                Id = 1,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            controller.Post(manager);
            var manager2 = controller.Get(1);
            Assert.IsTrue(manager2.Equals(manager));
        }

        [TestMethod()]
        public void PutTest()
        {
            var controller = new ManagerController();
            var manager = new Manager
            {
                Id = 1,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            var manager2 = new Manager
            {
                Id = 1,
                Name = "Recep",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            controller.Post(manager);
            controller.Put(1, manager2);

            var responseManager = controller.Get(1);
            Assert.IsTrue(responseManager.Name == "Recep");

        }

        [TestMethod()]
        public void DeleteTest()
        {
            var controller = new ManagerController();
            var manager = new Manager
            {
                Id = 1,
                Name = "Efe",
                Surname = "Mayoğlu",
                Password = "1234",
                UserName = "efemayoglu"
            };
            
            controller.Post(manager);
            controller.Delete(manager.Id);
            Assert.IsTrue(controller.managers.Count ==0);

        }
    }
}
