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

        double[] extraPoint = new double[4] { 3.68, 1.78, 5.34, 1.92 };

        Console.WriteLine("Student         Exam Score         Overall Grade    Extra Credit");
        //Console.WriteLine("{0,-15} {1,-12} {2,-15} {3,-10} {4,-12}", "Student", "Exam Score", "Overall Grade", "Grade", "Extra Credit")
        double currentAssignments = 5.0;

        for (int i = 0; i < nomeAluno.Length; i++)
        {
            int sum = 0;
            foreach (int nota in notas[i])
            {
                sum += nota;
            }
            double mediaFinal = sum / currentAssignments;

            // Calculando a nota total com a pontuação extra
            double overallGrade = mediaFinal + extraPoint[i];

            string grade;

            if (overallGrade >= 97)
            {
                grade = "A+";
            }
            else if (overallGrade >= 93)
            {
                grade = "A";
            }
            else if (overallGrade >= 90)
            {
                grade = "A-";
            }
            else if (overallGrade >= 87)
            {
                grade = "B+";
            }
            else if (overallGrade >= 83)
            {
                grade = "B";
            }
            else if (overallGrade >= 80)
            {
                grade = "B-";
            }
            else if (overallGrade >= 77)
            {
                grade = "C+";
            }
            else if (overallGrade >= 73)
            {
                grade = "C";
            }
            else if (overallGrade >= 70)
            {
                grade = "C-";
            }
            else if (overallGrade >= 67)
            {
                grade = "D+";
            }
            else if (overallGrade >= 63)
            {
                grade = "D";
            }
            else if (overallGrade >= 60)
            {
                grade = "D-";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"{nomeAluno[i],-15} {mediaFinal,6:F1} {overallGrade,18:F1}  {grade,-5} {extraPoint[i],8:F1} pts");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
