using System;
using System.Globalization;

class aula04
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        decimal total = 0;
        string message = "";

        foreach (var value in values)
        {
            decimal number; 
            if (decimal.TryParse(value, out number))
            {
                total += number;
            }
            else
            {
                message += value;
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
}