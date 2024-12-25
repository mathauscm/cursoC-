using System;

class Aula08
{
    static void Main()
    {
        string[] nomeAluno = new string[4] { "Sophia", "Andrew", "Emma", "Logan" };
        int[][] notas = new int[][]
        {
            new int[5] { 90, 86, 87, 98, 100 },
            new int[5] { 92, 89, 81, 96, 90 },
            new int[5] { 90, 85, 87, 98, 68 },
            new int[5] { 90, 95, 87, 88, 96 }
        };

        Console.WriteLine("Student         Grade");
        double currentAssignments = 5.0;

        for (int i = 0; i < nomeAluno.Length; i++)
        {
            int sum = 0;
            foreach (int nota in notas[i])
            {
                sum += nota;
            }
            double mediaFinal = sum / currentAssignments;
            string grade;

            if (mediaFinal >= 97)
            {
                grade = "A+";
            }
            else if (mediaFinal >= 93)
            {
                grade = "A";
            }
            else if (mediaFinal >= 90)
            {
                grade = "A-";
            }
            else if (mediaFinal >= 87)
            {
                grade = "B+";
            }
            else if (mediaFinal >= 83)
            {
                grade = "B";
            }
            else if (mediaFinal >= 80)
            {
                grade = "B-";
            }
            else if (mediaFinal >= 77)
            {
                grade = "C+";
            }
            else if (mediaFinal >= 73)
            {
                grade = "C";
            }
            else if (mediaFinal >= 70)
            {
                grade = "C-";
            }
            else if (mediaFinal >= 67)
            {
                grade = "D+";
            }
            else if (mediaFinal >= 63)
            {
                grade = "D";
            }
            else if (mediaFinal >= 60)
            {
                grade = "D-";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"{nomeAluno[i],-15} {mediaFinal,5:F1}    {grade}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
