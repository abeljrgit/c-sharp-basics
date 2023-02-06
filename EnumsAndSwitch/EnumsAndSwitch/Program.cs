using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo {Description="Task 1",EstimatedHours=6,Status=Status.Completed},
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);
            Console.ReadLine();
            
          
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos) 
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }

        class Todo
        {
            public string Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status Status { get; set; }
        }

        enum Status
        {
            NotStarted,
            InProgress,
            OnHold,
            Completed,
            Deleted
        }
    }

   

}
