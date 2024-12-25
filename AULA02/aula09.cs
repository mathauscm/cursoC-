using System;

class Program
{
    static void Main()
    {
        // Declara e inicializa um array de duas strings
        string[] myStrings = new string[2]
        {
            "I like pizza. I like roast chicken. I like salad",
            "I like all three of the menu choices"
        };

        // Armazena o número de elementos no array
        int stringsCount = myStrings.Length;

        // Variáveis auxiliares
        string myString = "";
        int periodLocation = 0;

        // Loop principal para processar cada string no array
        for (int i = 0; i < stringsCount; i++)
        {
            // Inicializa myString com a string atual do array
            myString = myStrings[i];

            // Encontra a posição do primeiro ponto
            periodLocation = myString.IndexOf(".");

            // Variável para armazenar a sentença extraída
            string mySentence;

            // Extrai e exibe sentenças enquanto houver um ponto na string
            while (periodLocation != -1)
            {
                // Primeira sentença é o valor da string à esquerda da localização do ponto
                mySentence = myString.Remove(periodLocation);

                // O restante de myString é o valor à direita da localização do ponto
                myString = myString.Substring(periodLocation + 1);

                // Remove qualquer espaço em branco no início de myString
                myString = myString.TrimStart();

                // Atualiza a localização do ponto e incrementa o contador
                periodLocation = myString.IndexOf(".");

                // Exibe a sentença extraída
                Console.WriteLine(mySentence);
            }

            // Exibe a última parte da string, que não contém um ponto
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }
    }
}