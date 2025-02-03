using System;
using System.Collections.Generic;

namespace ToDoListManager
{
    class Program
    {
        static List<string> todoList = new List<string>();

        static void Main(string[] args)
        {
            int task = 0;

            Console.WriteLine("------------> Welcome to the To-Do List..! <------------");

            while (task != 4)
            {
                Console.WriteLine("\nEnter a command (1: add, 2: view, 3: delete, 4: exit): ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out task))
                {
                    switch (task)
                    {
                        case 1:
                            AddTask();
                            break;
                        case 2:
                            ViewTasks();
                            break;
                        case 3:
                            DeleteTask();
                            break;
                        case 4:
                            Console.WriteLine("Exiting the To-Do List. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid number.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    task = 0;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            todoList.Add(task);
            Console.WriteLine("Task added.");
        }

        static void ViewTasks()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
            }
            else
            {
                Console.WriteLine("===> To-Do List:");
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
            }
        }

        static void DeleteTask()
        {
            ViewTasks();
            if (todoList.Count > 0)
            {
                Console.Write("Enter the task number to delete: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
                {
                    todoList.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task deleted.");
                }
                else
                {
                    Console.WriteLine("Invalid task number");
                }
            }
        }
    }
}
