using System;

class aula17
{
    static void Main()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = input.IndexOf(openSpan);
        int closingPosition = input.IndexOf(closeSpan);

        openingPosition += openSpan.Length;
        int quantity = closingPosition - openingPosition;
        Console.WriteLine("Quantity: ", input.Substring(openingPosition, quantity));
        
        
        
        
        string output = "";

       

        Console.WriteLine(quantity);
        Console.WriteLine(output);



        //Quantity: 5000
        //Output: < h2 > Widgets & reg;</ h2 >< span > 5000 </ span >
    }
}