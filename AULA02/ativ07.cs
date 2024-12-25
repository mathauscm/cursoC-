using System;

class Program
{
    static void Main()
    {
        bool validEntry = false;

        do
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int entered))
            {
                if (entered >= 5 && entered <= 10)
                {
                    validEntry = true;
                    Console.WriteLine($"You input value {userInput} has been accepted.");
                }
                else
                    Console.WriteLine($"You entered {entered}. Please enter a number between 5 and 10");
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again.");
            }



        } while (!validEntry);
        //!validEntry para que o loop continue enquanto validEntry for false

    }
}