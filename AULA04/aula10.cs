using System;
class aula09
{
    static void Main()
    {
        /* 
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(status, false);
        Console.WriteLine($"End: {status}");

        void SetHealth(string status, bool isHealthy)
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }
        */
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(false);
        Console.WriteLine($"End: {status}");

        void SetHealth(bool isHealthy)
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }


    }
}