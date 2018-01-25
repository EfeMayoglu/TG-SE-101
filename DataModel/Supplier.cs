using System.Collections.Generic;

namespace DataModel

{
public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        
    }
}
