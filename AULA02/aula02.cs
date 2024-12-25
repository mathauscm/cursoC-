using System;

class aula02
{
    public static void Main()
    {
        Random coin = new Random();
        int flip = coin.Next(0, 2);

        Console.WriteLine((flip == 0) ? "Cara" : "Coroa");
        Console.WriteLine((coin.Next(0, 2) == 0) ? "Cara" : "Coroa");

    }
}