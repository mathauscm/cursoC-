using System;
class aula09
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArray(array);
        Clear(array);
        PrintArray(array);

        void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        void Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0; // aqui esotu definidos todos os elementos do array como 0
            }
        }
    }
}