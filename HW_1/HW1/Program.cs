public class Program
{
    static void Main(string[] args)
    {

        string nameShop = InputName();
        string id = InputID();
        string nameManagerShop = OwnerName();
        string RegisteredValue_str = RegisteredValue();
        int priceShop = ConvertStringToInt(RegisteredValue_str);
        ShopMedia shm1 = new ShopMedia(nameShop, id, nameManagerShop, priceShop);
        shm1.PrintData();
        string moneychang_str = MoneyForChang();
        float _Coin = ConvertStringToFloat(moneychang_str);
        ShopMedia.CoinChang(_Coin);
    }

    public static string InputName()
    {
        Console.Write("Please input Name : ");

        return Console.ReadLine();
    }

    public static string InputID()
    {
        Console.Write("Please input ID: ");
        return Console.ReadLine();
    }

    public static string OwnerName()
    {
        Console.Write("Please input Owner Name: ");
        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value)
    {
        if (int.TryParse(value, out int number)) { return number; }
        throw new Exception("Please input decimal data.");
    }

    public static float ConvertStringToFloat(string value)
    {
        if (float.TryParse(value, out float number)) { return number; }
        throw new Exception("Please input float data.");
    }
    public static string RegisteredValue()
    {
        Console.Write("Please input Registered Value: ");
        return Console.ReadLine();
    }
    public static string MoneyForChang()
    {
        Console.Write("Please input Money for Chang : ");
        return Console.ReadLine();
    }
}