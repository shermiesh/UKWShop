using UKWShop.DAL;

namespace UKWShop.Models.Infrastructure
{
    public class CartManager : ICartManager
    {
        public void AddToCart(ISession session, int filmId, FilmsContext db)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCartItems(ISession session)
        {
            var cart = SessionHelper.GetCart<List<CartItem>>(session, Consts.CartSessionKey);

            if (cart == null) cart = new List<CartItem>();

            return cart;
        
        }

        public int GetCartQuantity(ISession session)
        {
            var cart = GetCartItems(session);

            return cart.Sum(i => i.Quantity);
        }

        public decimal GetCartValue(ISession session)
        {
            var cart = GetCartItems(session);

            return cart.Sum(i => i.Value);
        }

        public int RemoveFromCart(ISession session, int filmId)
        {
            throw new NotImplementedException();
        }
    }
}
