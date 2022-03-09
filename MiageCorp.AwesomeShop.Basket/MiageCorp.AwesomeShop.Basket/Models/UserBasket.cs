namespace MiageCorp.AwesomeShop.Basket.Models
{
    public class UserBasket
    {
        public string? UserId { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
