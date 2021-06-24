using System;
namespace ShoppingCart
{
  public class Sales
  {
    public void processPayment(object sender, Cart cart)
    {
      Console.WriteLine("\n\nSALES/PURCHASING");
      Console.WriteLine($"Procesing payment for ${cart.Total():N2}");
    }
  }
}