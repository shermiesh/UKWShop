using UKWShop.DAL;

namespace UKWShop.Models.Infrastructure
{
    public interface ICartManager
    {
        /// Pobranie elementów całego koszyka; lista karty itemów
        /// 
        public List<CartItem> GetCartItems(ISession session);
        
        public void AddToCart(ISession session, int filmId, FilmsContext db);

        public int RemoveFromCart(ISession session, int filmId);

        public int GetCartQuantity(ISession session);

        public decimal GetCartValue(ISession session);



    }
}
