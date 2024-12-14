using System;
using System.Collections.Generic;

class Task
{
    public string Title { get; set; }
    public bool IsComplete { get; set; } = false;
}

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DisplayTasks();
            Console.WriteLine("\n1. Add Task");
            Console.WriteLine("2. Mark Task Complete");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");

            Console.WriteLine("\nSelect an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void DisplayTasks()
    {
        Console.WriteLine("To-Do List:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks added yet.\n");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. [{(tasks[i].IsComplete ? "X" : " ")}] {tasks[i].Title}");
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("\nEnter task title: ");
        var title = Console.ReadLine();
        tasks.Add(new Task { Title = title });
    }

    static void CompleteTask()
    {
        Console.WriteLine("\nEnter task number to mark complete: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number <= tasks.Count && number > 0)
        {
            tasks[number - 1].IsComplete = true;
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    static void DeleteTask()
    {
        Console.WriteLine("\nEnter task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number <= tasks.Count && number > 0)
        {
            tasks.RemoveAt(number - 1);
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}