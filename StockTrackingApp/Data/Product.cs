namespace StockTrackingApp.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = null!;

        public string Brand { get; set; }

        public int Quantity{ get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }
}
