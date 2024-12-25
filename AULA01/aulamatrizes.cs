using System;

class aulamatrizes
{
    static void Main()
    {
		/*string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //fraudulentOrderIDs[3] = "D000";
        */
        string[] fraudulentOrderIDs = { "A123", "B456", "C678" };

		Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");



    }
}