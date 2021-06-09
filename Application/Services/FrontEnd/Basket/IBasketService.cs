namespace Application.Services.FrontEnd.Basket
{
    public interface IBasketService
    {
        BasketDto GetOrCreateBasketForUser(string buyerId);
        void AddItemToBasket(long basketId, long productId, int quantity = 1);
        bool RemoveItemFromBasket(int itemId);
        bool SetQuantities(int itemId, int quantity);
        BasketDto GetBasketForUser(string userId);
        void TransferBasket(string anonymousId, string userId);
    }
}
