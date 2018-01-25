namespace DataModel

{
    public class SupplierProduct
    {
        public int Id { get; set; }

        public Supplier Supplier { get; set; }

        public Product Product { get; set; }
    }
}
