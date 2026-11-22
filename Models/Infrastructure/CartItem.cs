namespace UKWShop.Models.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }
        public int Quantity { get; set; }

        public Decimal Value { get; set; } //quantity * Film.Price


    }
}
