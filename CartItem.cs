namespace ShoppingCart
{
  public class CartItem
  {
    public Item Product { get; set; }
    public int Quantity { get; set; } = 1;
    public double SubTotal() => Product.Price * Quantity;
  }
}