using System;

class aula03
{
    static void Calculo(int num1, int num2)
    {
        int soma = num1 + num2;
        Console.WriteLine($"O resultado da soma é: {soma}");
    }

    static void Main()
    {
        int num1 = 10;
        int num2 = 10;
        Calculo(num1, num2);
    }
}