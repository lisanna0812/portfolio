#  Student Management System (C#)

This project demonstrates the use of a Student class that models student information, their grades, and provides methods for analyzing academic performance by groups.

##  Description

The `Student` class stores:
- the student's surname,
- the group number,
- the list of grades.

It also includes methods for:
- displaying students by groups,
- counting top-performing students,
- finding students with only failing grades,
- accessing individual grades through an indexer.

The project can be used for practicing OOP in C#, working with arrays, LINQ, and static methods.

##  Features

- Check if a student has only failing grades (`AllGradesTwo`)
- Check if a student has only top grades (`AllGradesTen`)
- Count the number of excellent students in each group (`CountExcellentStudents`)
- Display students from a specific group (`ResultSession`)
- Find and display students whose grades are all 2 (`PrintAllStudentsWithTwo`)
- Indexer for accessing individual grades (`this[int index]`)


## Core Concepts

Encapsulation — student fields are protected by properties Surname, NumberGroup and Grades.

Indexers — access to individual grades is implemented via student[i].

LINQ — used for filtering and sorting students.

Static methods — allow working with arrays of students without creating separate class instances.

##  Example Usage

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Student[] students =
        {
            new Student("Ivanov", "A1", new int[] { 10, 10, 10 }),
            new Student("Petrov", "A1", new int[] { 2, 2, 2 }),
            new Student("Sidorov", "B1", new int[] { 9, 8, 7 }),
            new Student("Smirnova", "B1", new int[] { 10, 10, 10 })
        };

        Console.WriteLine("=== Students from group A1 ===");
        Student.ResultSession(students, "A1");

        Console.WriteLine("\n=== Excellent Students ===");
        Student.CountExcellentStudents(students);

        Console.WriteLine("\n=== Students with all grades = 2 ===");
        Student.PrintAllStudentsWithTwo(students);
    }
}
