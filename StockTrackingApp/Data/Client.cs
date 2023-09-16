namespace StockTrackingApp.Data
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
