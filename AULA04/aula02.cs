using System;

class aula02
{
    static void Main()
    {
        Console.WriteLine("Beforew calling a method");
        SayHello();
        Console.WriteLine("After calling a method");

    }
    static void SayHello()
    {
        Console.WriteLine("Hello Word");
    }
}