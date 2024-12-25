using System;

public class Program
{
    public static void Main()
    {
        // Exemplo de três arrays
        string[] array1 = { "a", "b", "c" };
        int[] array2 = { 1, 2, 3 };
        double[] array3 = { 1.1, 2.2, 3.3 };
        
        // Use um loop for para iterar sobre os arrays
        for (int i = 0; i < array1.Length; i++)
        {
            // Associe os itens correspondentes de cada array
            string item1 = array1[i];
            int item2 = array2[i];
            double item3 = array3[i];
            
            // Faça algo com os itens associados, por exemplo, imprima-os
            Console.WriteLine($"Item 1: {item1}, Item 2: {item2}, Item 3: {item3}");
        }
    }
}
