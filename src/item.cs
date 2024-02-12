using System;

namespace shopping_cart_github;

public class Item
{
    public string Name { get; set; } 
    
    // Stock count can be null for items not limited in supply.
    public int? Stock { get; set; }
    public int Price { get; set; }
    
    public Item(string name, int? stock, int price)
    {
        this.Name = name;
        this.Stock = stock;
        this.Price = price;
    }
}