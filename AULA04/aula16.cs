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
        int start = 0; // �ndice inicial
        int end = word.Length - 1; // �ndice final

        // Verifica os caracteres de ambos os lados movendo-se para o centro
        while (start < end)
        {
            if (word[start] != word[end])
            {
                return false; // Se os caracteres n�o correspondem, n�o � um pal�ndromo
            }
            start++;
            end--;
        }

        return true; // Se todos os caracteres correspondem, � um pal�ndromo
    }
}
