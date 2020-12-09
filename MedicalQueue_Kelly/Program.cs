using System;

namespace MedicalQueue_Kelly
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue queue = new ERQueue();
            while (true)
            {
                Console.WriteLine("(A)dd Patient");
                Console.WriteLine("(P)rocess Current Patient");
                Console.WriteLine("(L)ist All in Queue");
                Console.WriteLine("(Q)uit\n");
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    default:
                        Console.WriteLine("Choose a valid option:\n");
                        break;
                    case ConsoleKey.A:
                        Console.Write("Enter patient's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter patient's priority number: ");
                        int priority = Convert.ToInt32(Console.ReadLine());
                        Patient patient = new Patient(name, priority);
                        if (queue.EnQueue(patient) == -1)
                        {
                            Console.WriteLine("Queue is full.\n");
                        }
                        else
                        {
                            Console.WriteLine(name + " was added to the queue.");
                            Console.WriteLine("There are " + queue.list.Count + " patients in the queue.\n");
                        }
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine($"{queue.DeQueue()}");
                        break;
                    case ConsoleKey.L:
                        Console.WriteLine(queue.ToString());
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}