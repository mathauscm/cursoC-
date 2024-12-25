using System;
class aula02
{
    public static void Main()
    {
        Console.WriteLine("Conversor de temperaturas");
        Console.WriteLine(@"Digite (1) Converter C° para F°  
Digite (2) Converter F° para C°");
       int escolha = int.Parse(Console.ReadLine());
       Console.WriteLine("Digite a temperatura");
       double temp = double.Parse(Console.ReadLine());

       if (escolha == 1)
       {
        double result1 = temp * 1.8 + 32;
        Console.WriteLine("The temperatura is: {0}° Fahrenheit", result1);
       }
       else if (escolha == 2)
       {
        double result2 = (temp - 32) / 1.8;
        Console.WriteLine("The temperature is: {0}° Celsius", result2);
       }
       else
       {
        Console.WriteLine("Escolha a opção 1 ou 2");
        
       }

    }
}