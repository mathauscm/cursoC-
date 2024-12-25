using System;

class aula11
{
    static void Main()
    {
        /*string first = "Hello";
        string second = "World";
        string result = string.Format("{0} {1}!", first, second);
        Console.WriteLine(result);
        
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));

        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-'));
        */

        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }
}