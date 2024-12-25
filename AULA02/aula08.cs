using System;

class Program
{
    static void Main()
    {
        bool validEntry = false;
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        do
        {
            string userInput = Console.ReadLine();
            userInput = userInput.Trim().ToLower();

            if (userInput == "administrator" || userInput == "manager" || userInput == "user")
            {
                validEntry = true;
                Console.WriteLine($"Your input value \"{userInput}\" has been accepted.");
            }
            else
            {
                Console.WriteLine($"The role name that you entered, \"{userInput}\", is not valid. Enter your role name (Administrator, Manager, or User).");
            }

        } while (!validEntry);
        // !validEntry para que o loop continue enquanto validEntry for false
    }
}