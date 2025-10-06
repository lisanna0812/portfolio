class Student
{
    public string Surname { get; set; }
    public string NumberGroup { get; set; }
    public int[] Grades { get; set; }

    public int this[int index]
    {
        get { return Grades[index]; }
        set { Grades[index] = value; }
    }

    /// <summary>
    /// Initializes a new student.
    /// </summary>
    public Student(string surname, string groupNumber, int[] grades)
    {
        Surname = surname;
        NumberGroup = groupNumber;
        Grades = grades;
    }

    /// <summary>
    /// Checks if all grades are 2.
    /// </summary>
    public bool AllGradesTwo()
    {
        for (int i = 0; i < Grades.Length; i++)
        {
            if (Grades[i] != 2)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Checks if all grades are 10.
    /// </summary>
    public bool AllGradesTen()
    {
        for (int i = 0; i < Grades.Length; i++)
        {
            if (Grades[i] != 10)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Displays students of a specific group.
    /// </summary>
    public static void ResultSession(Student[] students, string groupNumber)
    {
        var filterStudents = students.Where(s => s.NumberGroup == groupNumber)
                                     .OrderBy(s => s.Surname)
                                     .ToArray();

        for (int i = 0; i < filterStudents.Length; i++)
        {
            Console.WriteLine($"Surname: {filterStudents[i].Surname}, Group: {filterStudents[i].NumberGroup}, Grades: {string.Join(", ", filterStudents[i].Grades)}");
        }
    }

    /// <summary>
    /// Counts excellent students in group.
    /// </summary>
    public static void CountExcellentStudents(Student[] students)
    {
        var groupNames = students.Select(s => s.NumberGroup)
                                 .Distinct()
                                 .ToArray();
        for (int i = 0; i < groupNames.Length; i++)
        {
            string groupName = groupNames[i];
            int count = students.Count(s => s.NumberGroup == groupName && s.AllGradesTen());
            if (count > 0)
            {
                Console.WriteLine($"Group: {groupName}, Excellent Students: {count}");
            }
        }
    }

    /// <summary>
    /// Displays students with all grades of 2.
    /// </summary>
    public static void PrintAllStudentsWithTwo(Student[] students)
    {
        int count = 0;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].AllGradesTwo())
            {
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No students with all grades of 2.");
        }
        else
        {
            Student[] twoStudents = new Student[count];
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].AllGradesTwo())
                {
                    twoStudents[index] = students[i];
                    index++;
                }
            }

            for (int i = 0; i < twoStudents.Length; i++)
            {
                Console.WriteLine($"Surname: {twoStudents[i].Surname}, Group: {twoStudents[i].NumberGroup}, Grades: {string.Join(", ", twoStudents[i].Grades)}");
            }
        }
    }
}
