using System;

class aula13
{
    static void Main()
    {
		/*string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        Console.WriteLine(openingPosition);
        Console.WriteLine(closingPosition);
        openingPosition += 1;

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
        

		string message = "What is the value <span>between the tags</span>?";

        int openingPosition = message.IndexOf("<span>");
        int closingPosition = message.IndexOf("</span>");

        openingPosition += 6;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
        */
        
        string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += openSpan.Length; // ou 6 seria a mesma coisa
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
        
    }
}