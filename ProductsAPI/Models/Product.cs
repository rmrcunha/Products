namespace ProductsAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public productCategory Category { get; set; }
    }

    public enum productCategory
    {
        Food = 0,
        Conveniences = 1,
        Commodities = 2,
        Durable = 3,
        Digital = 4
    }
}
