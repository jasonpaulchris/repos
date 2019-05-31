namespace Sports.Models
{
    public class Product
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }

        public long CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
