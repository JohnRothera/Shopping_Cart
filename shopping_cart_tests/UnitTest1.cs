using shopping_cart_github;

namespace shopping_cart_tests;

public class UnitTest1
{
    [Fact]
    public void ItemTest()
    {
        Item item = new("testItem", 2, 50);
        Assert.Equal("testItem", item.Name);
    }

    [Fact]
    public void AddCartItemTestAndInventorySetup()
    {
        // Arrange
        var inventory = new StockInventory();
        var shoppingCart = new Cart(inventory);
        var item = new Item("TestItem", 10, 5);
        inventory.AddItem(item); // Add item to inventory

        // Redirect console output to a StringWriter
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            shoppingCart.AddItemToCart(item, 3);

            // Assert
            string expectedOutput = "3 TestItem(s) added to the cart.";
            Assert.Equal(expectedOutput, sw.ToString().Trim());
        }
    }
}