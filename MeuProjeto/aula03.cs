using System;

class aula03
{
    public static void Main()
    {
        int[,] notas = new int[4, 5] {{93, 87, 98, 95, 100}, {80, 83, 82, 88, 85}, {84, 96, 73, 85, 79}, {90, 92, 98, 100, 97}};
        string[] nome = {"Sophia", "Nicolas", "Zahirah", "Jeong"};

        Console.WriteLine("Student     Grade");

        for (int i = 0; i < notas.GetLength(0); i++) 
        {            
            int soma = 0;
            
            for (int j = 0; j < notas.GetLength(1); j++) 
            {
                soma += notas[i, j];
            }

            double media = (double)soma / notas.GetLength(1); 
            string nota;
            if (media > 90)
            {
                nota = "A";
            }
            else
            {
                nota = "B";
            }

            Console.WriteLine("{0,10} {1,5:F1} {2}", nome[i], media, nota); 
        } 
    }
}
