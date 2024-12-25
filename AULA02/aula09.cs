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

        // Armazena o n�mero de elementos no array
        int stringsCount = myStrings.Length;

        // Vari�veis auxiliares
        string myString = "";
        int periodLocation = 0;

        // Loop principal para processar cada string no array
        for (int i = 0; i < stringsCount; i++)
        {
            // Inicializa myString com a string atual do array
            myString = myStrings[i];

            // Encontra a posi��o do primeiro ponto
            periodLocation = myString.IndexOf(".");

            // Vari�vel para armazenar a senten�a extra�da
            string mySentence;

            // Extrai e exibe senten�as enquanto houver um ponto na string
            while (periodLocation != -1)
            {
                // Primeira senten�a � o valor da string � esquerda da localiza��o do ponto
                mySentence = myString.Remove(periodLocation);

                // O restante de myString � o valor � direita da localiza��o do ponto
                myString = myString.Substring(periodLocation + 1);

                // Remove qualquer espa�o em branco no in�cio de myString
                myString = myString.TrimStart();

                // Atualiza a localiza��o do ponto e incrementa o contador
                periodLocation = myString.IndexOf(".");

                // Exibe a senten�a extra�da
                Console.WriteLine(mySentence);
            }

            // Exibe a �ltima parte da string, que n�o cont�m um ponto
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }
    }
}