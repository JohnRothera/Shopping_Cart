using shopping_cart_github;

namespace shopping_cart_tests;

public class UnitTest1
{
    [Fact]
    public void ItemTest()
    {
        Item item = new("testItem");
        Assert.Equal("testItem", item.Name);
    }

    [Fact]
    public void AddCartItemTest()
    {
        Item item = new("testItem");
        Cart cart = new Cart(); 

        string actualOutput = cart.addItem(item);
        string expectedOutput = "Item: testItem added";  
        Assert.Equal(expectedOutput, actualOutput);
    }
}