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

            openingPosition += 1; // para apontar para o caractere imediatamente apos parêntese
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            
            message = message.Substring(closingPosition +1);
            // atualiza a message para a parte da string que começa logo após o parêntese de fechamento,
            // para processar o próximo conjunto de parênteses no próximo ciclo do laço.
        }
    }
}