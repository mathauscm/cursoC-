using System;

class aula03
{
    static void Main()
    {
        string permissao = "Admin|Manager";
        int level = 55;

        Console.WriteLine("Select User\n 1 - Admin\n 2 - Manager\n");
        int user = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter user Level");
        int levelUser = int.Parse(Console.ReadLine());


        Console.WriteLine((user == 1) ? "Admin" : "Manager");
        //Console.WriteLine((levelUser > level) ? "Welcome, Super Admin user." : "Welcome, Admin user");

        if (user == 1)
        {
            Console.WriteLine((levelUser > level) ? "Welcome, Super Admin user." : "Welcome, Admin user");
        }

        if (user == 2)
        {
            Console.WriteLine((levelUser >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
        }
        if (user > 2 || user < 0 ) {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}