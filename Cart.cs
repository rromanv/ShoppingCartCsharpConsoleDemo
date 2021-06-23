using System.Collections;
using System.Collections.Generic;

namespace ShoppingCart
{
  public class Cart : IEnumerable
  {
    public List<CartItem> Items = new();

    public void ClearInventory() => Items.Clear();

    public int Count => Items.Count;

    IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();


    private double _subTotal = 0;
    private const double tax = 8.25;
    public double SubTotal
    {
      get
      {
        foreach (CartItem item in this)
        {
          _subTotal += item.SubTotal();
        }
        return _subTotal;
      }
    }

    public double Total { get => ((_subTotal * tax) + _subTotal) / 100; }
  }
}