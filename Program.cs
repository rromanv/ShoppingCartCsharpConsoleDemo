using System;
using System.Linq;
using ShoppingCart;

Inventory inventory = new();

inventory.Add(new() { Name = "iMac Latest", Price = 1_200 });
inventory.Add(new() { Name = "Mac Mini", Price = 700 });
inventory.Add(new() { Name = "MacBook Air", Price = 1_000 });
inventory.Add(new() { Name = "MacBook Pro", Price = 1_300 });

var obj = inventory.Items.Find(x => x.Name == "Mac  Mini");

if (obj is not null) obj.Price = 8_999;

foreach (Item item in inventory)
{
  Console.WriteLine(String.Format("{0} {1,15} \t${2,10:N}", item.ID, item.Name, item.Price));
}



