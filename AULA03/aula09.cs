using System;

class aula09
{
    static void Main()
    {
        
        string first = "Hello";
        
        string second = "World";
        string result = string.Format("{0} {1}!", first, second);
        Console.WriteLine(result);

        _________________________________________
        
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        _________________________________________

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");

        _________________________________________
        decimal tax = .36785m;
                
        Console.WriteLine($"Tax rate: {tax:P2}");

        _________________________________________

        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        Console.WriteLine(yourDiscount);

        _________________________________________


        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
        Console.WriteLine(yourDiscount);

    }
}