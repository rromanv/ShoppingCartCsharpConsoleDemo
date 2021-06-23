using System.Collections;
using System.Collections.Generic;

namespace ShoppingCart
{
  public class Inventory : IEnumerable
  {
    public List<Item> Items = new();

    public void ClearInventory() => Items.Clear();
    public void Add(Item item) => Items.Add(item);

    public int Count => Items.Count;

    IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();
  }
}
