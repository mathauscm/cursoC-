using System;

class fizzbuzz
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            
            if ((i % 5 == 0) && (i % 3 == 0))
            {
                Console.WriteLine($"{i} - FizzBuzz");
            }

            if(i % 5 == 0)
            {
                Console.WriteLine($"{i} - Buzz");
            }

            if (i % 3 == 0)
            {
                Console.WriteLine($"{i} - Fizz");
            }
            else
                Console.WriteLine(i);

        }
    }
}