using System;

class aula07
{
    static void Main()
    {
        string [] IDs = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };


        foreach (string flag in IDs )
        {
            if (flag.StartsWith("B"))
            {
                Console.WriteLine(flag);
            }
        }
        
        
        /*string name = "Moa";
        
        if (name.StartsWith("B"))
        {
            Console.WriteLine("The name starts with 'B'!");
        }
        */
    }
}