namespace StockTrackingApp.Data
{
    public class Sale
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public DateTime SaleDate { get; set; } = DateTime.Now;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
