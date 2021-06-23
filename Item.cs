using System;
using shortid;
using shortid.Configuration;

namespace ShoppingCart
{
  public class Item
  {
    public string ID { get; } = ShortId.Generate(new GenerationOptions
    {
      UseSpecialCharacters = false,
      Length = 8,
      UseNumbers = false
    });
    public string Name { get; set; }
    public double Price { get; set; } = 1.00;
  }
}