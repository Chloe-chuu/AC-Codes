using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program1
{
    static void Main()
    {
        Student[] students = new Student[10];
        int studentCount = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       STUDENT RECORD MANAGEMENT        ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    if (studentCount >= 10)
                    {
                        Console.WriteLine("Cannot add more students. Maximum limit of 10 reached!\n");
                        break;
                    }

                    Student newStudent;
                    Console.Write("Enter Student Number: ");
                    newStudent.StudentNumber = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    newStudent.Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    newStudent.Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    int.TryParse(Console.ReadLine(), out newStudent.YearLevel);

                    students[studentCount] = newStudent;
                    studentCount++;

                    Console.WriteLine("\nStudent added successfully!\n");
                    break;

                case "2":
                    if (studentCount == 0)
                    {
                        Console.WriteLine("No student records found.\n");
                        break;
                    }

                    Console.WriteLine("========================================");
                    Console.WriteLine("            STUDENT RECORDS             ");
                    Console.WriteLine("========================================");
                    for (int i = 0; i < studentCount; i++)
                    {
                        Console.WriteLine($"Student Number: {students[i].StudentNumber}");
                        Console.WriteLine($"Name: {students[i].Name}");
                        Console.WriteLine($"Program: {students[i].Program}");
                        Console.WriteLine($"Year Level: {students[i].YearLevel}");
                        Console.WriteLine("----------------------------------------");
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Enter Student Number to search: ");
                    string searchNum = Console.ReadLine();
                    int foundIndex = -1;

                    for (int i = 0; i < studentCount; i++)
                    {
                        if (students[i].StudentNumber.Equals(searchNum, StringComparison.OrdinalIgnoreCase))
                        {
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex != -1)
                    {
                        Console.WriteLine("\nStudent Found!");
                        Console.WriteLine($"Student Number: {students[foundIndex].StudentNumber}");
                        Console.WriteLine($"Name: {students[foundIndex].Name}");
                        Console.WriteLine($"Program: {students[foundIndex].Program}");
                        Console.WriteLine($"Year Level: {students[foundIndex].YearLevel}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent not found.\n");
                    }
                    break;

                case "4":
                    Console.Write("Enter Student Number to update: ");
                    string updateNum = Console.ReadLine();
                    int updateIndex = -1;

                    for (int i = 0; i < studentCount; i++)
                    {
                        if (students[i].StudentNumber.Equals(updateNum, StringComparison.OrdinalIgnoreCase))
                        {
                            updateIndex = i;
                            break;
                        }
                    }

                    if (updateIndex != -1)
                    {
                        Console.Write("Enter New Name: ");
                        students[updateIndex].Name = Console.ReadLine();
                        Console.Write("Enter New Program: ");
                        students[updateIndex].Program = Console.ReadLine();
                        Console.Write("Enter New Year Level: ");
                        int.TryParse(Console.ReadLine(), out students[updateIndex].YearLevel);

                        Console.WriteLine("\nStudent record updated successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent not found.\n");
                    }
                    break;

                case "5":
                    Console.Write("Enter Student Number to delete: ");
                    string deleteNum = Console.ReadLine();
                    int deleteIndex = -1;

                    for (int i = 0; i < studentCount; i++)
                    {
                        if (students[i].StudentNumber.Equals(deleteNum, StringComparison.OrdinalIgnoreCase))
                        {
                            deleteIndex = i;
                            break;
                        }
                    }

                    if (deleteIndex != -1)
                    {
                        for (int i = deleteIndex; i < studentCount - 1; i++)
                        {
                            students[i] = students[i + 1];
                        }
                        studentCount--;
                        Console.WriteLine("\nStudent record deleted successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent not found.\n");
                    }
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Program exited.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
