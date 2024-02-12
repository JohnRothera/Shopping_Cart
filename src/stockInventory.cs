using System;

namespace shopping_cart_github;

public class StockInventory
{
    private Dictionary<string, Item> items = new Dictionary<string, Item>();

    public void AddItem(Item item)
    {
        if (items.ContainsKey(item.Name))
        {
            // If item already exists, update its stock. 
            items[item.Name].Stock += item.Stock;
        }
        else
        {
            // If item is new, add it to the inventory.
            items.Add(item.Name, item);
        }
    }

    // Add multiple items method.
    public void AddItems(List<Item> itemsToAdd)
    {
        foreach (var item in itemsToAdd)
        {
            AddItem(item);
        }
    }

    public Item? GetItemByName(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            return items[itemName];
        }
        else
        {
            Console.WriteLine($"Item with name '{itemName}' not found in the inventory.");
            return null;
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in items.Values)
        {
            Console.WriteLine($"Name: {item.Name}, Price: ${item.Price}, Stock Count: {item.Stock}");
        }
    }
}