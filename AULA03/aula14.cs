using System;

class aula14
{
    static void Main()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1; // para apontar para o caractere imediatamente apos par�ntese
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            
            message = message.Substring(closingPosition +1);
            // atualiza a message para a parte da string que come�a logo ap�s o par�ntese de fechamento,
            // para processar o pr�ximo conjunto de par�nteses no pr�ximo ciclo do la�o.
        }
    }
}