using System;

class aula09
{
    static void Main()
    {
        /*
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
        */

        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox") == false);
        Console.WriteLine(!pangram.Contains("fox"));


    }
}