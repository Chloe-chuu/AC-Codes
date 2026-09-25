using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program3
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("         STUDENT REQUEST QUEUE          ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    StudentRequest req;
                    Console.Write("Enter Student Number: ");
                    req.StudentNumber = Console.ReadLine();
                    Console.Write("Enter Student Name: ");
                    req.StudentName = Console.ReadLine();
                    Console.Write("Enter Request Type: ");
                    req.RequestType = Console.ReadLine();

                    requestQueue.Enqueue(req);
                    Console.WriteLine("\nRequest added successfully!\n");
                    break;

                case "2":
                    if (requestQueue.Count == 0)
                    {
                        Console.WriteLine("No pending requests in the queue.\n");
                        break;
                    }

                    Console.WriteLine("REQUEST QUEUE");
                    int position = 1;
                    foreach (StudentRequest request in requestQueue)
                    {
                        Console.WriteLine($"{position}. {request.StudentName} - {request.RequestType}");
                        position++;
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    if (requestQueue.Count == 0)
                    {
                        Console.WriteLine("No pending requests to process.\n");
                        break;
                    }

                    StudentRequest processedReq = requestQueue.Dequeue();
                    Console.WriteLine($"Processing Request: {processedReq.StudentName} - {processedReq.RequestType}");
                    Console.WriteLine("\nRequest processed successfully!\n");
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
