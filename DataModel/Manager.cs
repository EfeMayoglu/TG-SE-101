using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel

{
    public class Manager
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual List<Supplier> Suppliers { get; set; }
    }
}
