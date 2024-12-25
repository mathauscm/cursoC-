using System;
class aula07
{
    static void Main()
    {
        string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

        DisplayStudents(students);
        DisplayStudents(new string[] { "Robert", "Vanya" });

        void DisplayStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine();
        }
    }
}