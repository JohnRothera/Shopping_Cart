using System;

namespace shopping_cart_github;

// List of functions to include in project:

// AddItem: Add an item to the shopping cart. DONE
// RemoveItem: Remove an item from the shopping cart.
// UpdateItemQuantity: Update the quantity of a specific item in the shopping cart. DONE
// ClearCart: Remove all items from the shopping cart.
// GetItemCount: Get the total count of items in the shopping cart.
// GetTotalPrice: Calculate the total price of all items in the shopping cart.
// ApplyCoupon: Apply a coupon or discount code to the shopping cart.
// RemoveCoupon: Remove a previously applied coupon or discount code from the shopping cart.
// GetCartContents: Retrieve a list of items currently in the shopping cart.
// CheckOut: Proceed to checkout, potentially involving payment processing and order confirmation.
// SaveCartState: Save the current state of the shopping cart for later retrieval.
// LoadCartState: Load a previously saved state of the shopping cart.
// DisplayCart: Display the contents of the shopping cart to the user.
// ValidateCart: Validate the contents of the shopping cart to ensure all items are 
// available and meet any requirements (e.g., minimum order amount).

public class Cart
{
    private Dictionary<string, int> cartItems = new Dictionary<string, int>();
    private StockInventory inventory;

    public Cart(StockInventory inventory)
    {
        this.inventory = inventory;
    }

    public void AddItemToCart(Item item, int quantity = 1)
    {
        Item? inventoryItem = inventory.GetItemByName(item.Name);
        if (inventoryItem != null && inventoryItem.Stock >= quantity)
        {
            if (cartItems.ContainsKey(item.Name))
            {
                cartItems[item.Name] += quantity;
            }
            else
            {
                cartItems.Add(item.Name, quantity);
            }
            Console.WriteLine($"{quantity} {item.Name}(s) added to the cart.");
        }
        else
        {
            Console.WriteLine($"Item {item.Name} is out of stock or the requested quantity is not available.");
        }
    }

}