using System;

class aula03
{
    static void Main()
    {
        string value = "1";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    }
}