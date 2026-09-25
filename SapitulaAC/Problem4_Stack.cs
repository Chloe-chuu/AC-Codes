using System;
using System.Collections.Generic;

class Program4
{
    static void Main()
    {
        Stack<string> actionHistory = new Stack<string>();

        actionHistory.Push("Added Student: Juan Dela Cruz");
        actionHistory.Push("Updated Program: Maria Santos (BSIT)");
        actionHistory.Push("Deleted Student: Pedro Reyes");
        actionHistory.Push("Added Student: Ana Gomez");

        Console.WriteLine("========================================");
        Console.WriteLine("         STUDENT ACTION HISTORY         ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Most recent action: {actionHistory.Peek()}\n");

        Console.WriteLine("Undoing last 2 actions...");
        Console.WriteLine($"Undone: {actionHistory.Pop()}");
        Console.WriteLine($"Undone: {actionHistory.Pop()}\n");

        Console.WriteLine($"Current active action: {actionHistory.Peek()}");
    }
}