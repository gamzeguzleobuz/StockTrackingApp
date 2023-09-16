namespace StockTrackingApp.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }
}
