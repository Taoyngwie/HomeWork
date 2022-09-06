public class ShopMedia
{
    string nameShop = "";
    string id = "";
    string nameManagerShop = "";
    int priceShop;

    public ShopMedia(string nameShop, string id, string nameManagerShop, int priceShop)
    {
        this.nameShop = nameShop;
        this.id = id;
        this.nameManagerShop = nameManagerShop;
        this.priceShop = priceShop;
    }

    public void PrintData()
    {
        Console.WriteLine("-----Shop Information-----");
        Console.WriteLine("Name: {0}", nameShop);
        Console.WriteLine("Number: {0}", id);
        Console.WriteLine("Owner Name: {0}", nameManagerShop);
        Console.WriteLine("Registered Value: {0}", priceShop);
        Console.WriteLine("--------------------------");
    }

    public static double[] CoinChang(double amount)
    {
        double[] coins = { 1000, 500, 100, 50, 20, 10, 5, 2, 1, .5, .25 };
        double[] result = new double[11];
        for (int i = 0; i < coins.Length; i++)
        {
            double count = amount / coins[i];
            result[i] = Math.Floor(count);
            Console.WriteLine("{0}:{1}", coins[i], Math.Floor(count));
            amount %= coins[i];
        }
        return result;
    }
}