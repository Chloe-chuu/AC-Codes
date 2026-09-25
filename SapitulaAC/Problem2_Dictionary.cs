using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program2
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    STUDENT LOOKUP USING DICTIONARY     ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Student Number: ");
                    string id = Console.ReadLine();

                    if (studentDictionary.ContainsKey(id))
                    {
                        Console.WriteLine("Error: Student Number already exists!\n");
                        break;
                    }

                    Student newStudent;
                    newStudent.StudentNumber = id;
                    Console.Write("Enter Name: ");
                    newStudent.Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    newStudent.Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    int.TryParse(Console.ReadLine(), out newStudent.YearLevel);

                    studentDictionary.Add(id, newStudent);
                    Console.WriteLine("\nStudent added successfully!\n");
                    break;

                case "2":
                    Console.Write("Enter Student Number to search: ");
                    string searchNum = Console.ReadLine();

                    if (studentDictionary.TryGetValue(searchNum, out Student foundStudent))
                    {
                        Console.WriteLine("\nStudent Found!");
                        Console.WriteLine($"Student Number: {foundStudent.StudentNumber}");
                        Console.WriteLine($"Name: {foundStudent.Name}");
                        Console.WriteLine($"Program: {foundStudent.Program}");
                        Console.WriteLine($"Year Level: {foundStudent.YearLevel}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent Number does not exist.\n");
                    }
                    break;

                case "3":
                    if (studentDictionary.Count == 0)
                    {
                        Console.WriteLine("No student records found.\n");
                        break;
                    }

                    Console.WriteLine("========================================");
                    Console.WriteLine("            STUDENT RECORDS             ");
                    Console.WriteLine("========================================");
                    foreach (KeyValuePair<string, Student> entry in studentDictionary)
                    {
                        Console.WriteLine($"Student Number: {entry.Value.StudentNumber}");
                        Console.WriteLine($"Name: {entry.Value.Name}");
                        Console.WriteLine($"Program: {entry.Value.Program}");
                        Console.WriteLine($"Year Level: {entry.Value.YearLevel}");
                        Console.WriteLine("----------------------------------------");
                    }
                    Console.WriteLine();
                    break;

                case "4":
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
