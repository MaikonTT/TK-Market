namespace Tk_Market.Domain.Products.Models
{
    public class Product
    {
        public long Id { get; set; }
        public long Code { get; set; }
        public string Description { get; set; }
        public decimal ProviderPrice { get; set; }
        public decimal TradingPrice { get; set; }
        public long Amount { get; set; }
    }
}