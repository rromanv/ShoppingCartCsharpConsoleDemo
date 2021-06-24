using System;
using ShoppingCart;

Inventory inventory = new();

Item imac = new() { Name = "iMac Latest", Price = 1_200 };
Item macmini = new() { Name = "Mac Mini", Price = 700 };
Item mbair = new() { Name = "MacBook Air", Price = 1_000 };
Item mbpro = new() { Name = "MacBook Pro", Price = 1_300 };

inventory.Add(imac);
inventory.Add(macmini);
inventory.Add(mbair);
inventory.Add(mbpro);

Menu menu = new();

Cart cart = new();

while (true)
{
  Console.Clear();
  menu.show();
  Console.Write("Option: ");
  string response = Console.ReadLine();
  switch (response)
  {
    case "add":
      {
        inventory.printInventory();
        Console.Write("\nWhat item would you like to add? (Type ID) ");
        string productID = Console.ReadLine();
        Console.Write("\nHow Many? ");

        Item product = inventory.Items.Find(x => x.ID == productID);

        if (product is not null & Int16.TryParse(Console.ReadLine(), out short productQty))
        {
          CartItem ci = new();
          ci.Product = product;
          ci.Quantity = productQty;
          cart.CartItems.Add(ci);
        }
        break;
      }
    case "quit":
      {
        Environment.Exit(0);
        break;
      }
    case "show":
      {
        cart.printCart();
        break;
      }
    case "clear":
      {
        cart.ClearItems();
        break;
      }
  }
}

