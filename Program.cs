using System;

class Program
{
    static void Main()
    {
        int numberOfStudents = 0;
        while (true)
        {
            Console.WriteLine("Enter the number of students:");
            if (int.TryParse(Console.ReadLine(), out numberOfStudents) && numberOfStudents > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        Student[] students = new Student[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter details for student {i + 1}:");

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Group Number: ");
            string groupNumber = Console.ReadLine();

            int[] grades = null;
            while (true)
            {
                Console.Write("Enter grades separated by space: ");
                try
                {
                    grades = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    if (grades.Length > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Grades cannot be empty. Please enter at least one grade.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter grades as integers separated by space.");
                }
            }

            students[i] = new Student(surname, groupNumber, grades);
        }

        Console.Write("\nEnter the group number to display students: ");
        string groupToDisplay = Console.ReadLine();
        Student.ResultSession(students, groupToDisplay);

        Console.WriteLine("\nCount of excellent students in group:");
        Student.CountExcellentStudents(students);

        Console.WriteLine("\nList of all students with all grades of 2:");
        Student.PrintAllStudentsWithTwo(students);

        Console.ReadLine();
    }
}