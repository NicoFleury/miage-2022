using MiageCorp.AwesomeShop.Basket.Models;

namespace MiageCorp.AwesomeShop.Basket.Services
{
    public interface IBasketService
    {
        void AddToBasket(string userId, Item item);
        void ClearBasket(string userId);
        List<Item> GetBasketContent(string userId);
        void RemoveFromBasket(string userId, string itemId);
    }
}