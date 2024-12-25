using System;

class aulaGPA
{
    static void Main()
    {
        string[] Curso = new string[5] { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
        int[] Notas = new int[5] { 4, 3, 3, 3, 4 };
        int[] Credito = new int[5] { 3, 3, 4, 4, 3 };

        int[] resultado = new int[Notas.Length];

        for (int i = 0; i < Notas.Length; i++)
        {
            resultado[i] = Notas[i] * Credito[i];
        }

        // Soma dos valores do array resultado
        int soma = 0;
        for (int i = 0; i < resultado.Length; i++)
        {
            soma += resultado[i];
        }

        // Soma dos valores do array1
        int soma2 = 0;
        for (int i = 0; i < Notas.Length; i++)
        {
            soma2 += Notas[i];
        }
        Console.WriteLine("Student: Sophia Johnson");
        Console.WriteLine("{0,-25} {1,-10} {2,-12}", "Course", "Grade", "Credit Hours");

        //print dados array
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0,-28} {1,-10} {2,-12}", Curso[i], Notas[i], Credito[i]);
        }

        // Cálculo da média
        double media = (double)soma / soma2; // Cast para double para evitar divisão inteira
        Console.WriteLine("Final GPA = {0:F2}", media);
    }
}