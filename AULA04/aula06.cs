using System;
class aula06
{
    static void Main()
    {
        CountTo(10);

        void CountTo(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}