using System;
using System.Collections;
using System.Collections.Generic;

namespace ShoppingCart
{
  public class Inventory : IEnumerable
  {
    public List<Item> Items = new();

    public void ClearInventory() => Items.Clear();
    public void Add(Item item) => Items.Add(item);

    public void AddRange(Item[] items) => Items.AddRange(items);

    public int Count => Items.Count;

    IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();

    public void printInventory()
    {
      Console.Clear();
      Console.WriteLine("WELCOME TO THE FAKESHOP - Our Products\n");
      Console.WriteLine("      ID            NAME              PRICE");
      foreach (Item item in this)
      {
        Console.WriteLine(String.Format("{0} {1,15} \t${2,10:N}", item.ID, item.Name, item.Price));
      }
    }
  }
}
