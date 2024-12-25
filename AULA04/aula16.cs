using System;

class Program
{
    static void Main()
    {
        string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words)
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }
    }

    static bool IsPalindrome(string word)
    {
        int start = 0; // Índice inicial
        int end = word.Length - 1; // Índice final

        // Verifica os caracteres de ambos os lados movendo-se para o centro
        while (start < end)
        {
            if (word[start] != word[end])
            {
                return false; // Se os caracteres não correspondem, não é um palíndromo
            }
            start++;
            end--;
        }

        return true; // Se todos os caracteres correspondem, é um palíndromo
    }
}
