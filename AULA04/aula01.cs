using System;

class aula01
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Contents of Array:");
        PrintArray(a);
    }

    static void PrintArray(int[] array)
    {
        foreach (int x in array)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine();
    }
}