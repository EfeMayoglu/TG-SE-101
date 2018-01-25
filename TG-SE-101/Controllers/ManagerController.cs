using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TG_SE_101.Controllers
{
    public class ManagerController : ApiController
    {
        public List<Manager> managers = new List<Manager>();
        // GET api/values
        public IEnumerable<Manager> Get()
        {
            return managers;
        }

        public Manager CheckLogin(string userName, string password)
        {
            return managers.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }
        // GET api/values/5
        public Manager Get(int id)
        {
            return managers.FirstOrDefault(x=>x.Id ==id);
        }

        // POST api/values
        public void Post([FromBody]Manager manager)
        {
            managers.Add(manager);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Manager manager)
        {
            var manager2 = managers.FirstOrDefault(x => x.Id == id);
            if (manager2!=null)
            {
                manager2.UserName = manager.UserName;
                manager2.Password = manager.Password;
                manager2.Name = manager.Name;
                manager2.Surname = manager.Surname;
             
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var manager = managers.FirstOrDefault(x => x.Id == id);
            if (manager!=null)
            {
                managers.Remove(manager);
            }
        }
    }
}
