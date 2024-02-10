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
}