using System;

class Program
{
    static void Main()
    {
        string input = "there are snakes at the zoo";

        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));
    }

    static string ReverseSentence(string input)
    {
        string result = "";
        string[] words = input.Split(' '); // Correção aqui
        foreach (string word in words)
        {
            result += ReverseWord(word) + " ";
        }
        return result.Trim();
    }

    static string ReverseWord(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }
        return result;
    }
}
