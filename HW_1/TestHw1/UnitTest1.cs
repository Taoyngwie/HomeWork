namespace TestHw1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double number = 5120.25;
        double[] expected = { 5, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 };
        double[] actual = ShopMedia.CoinChang(number);
        Assert.Equal(actual, expected);
    }
}