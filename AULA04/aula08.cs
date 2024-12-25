using System;
class aula08
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }
    }
}