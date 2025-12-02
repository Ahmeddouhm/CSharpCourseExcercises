namespace Task_TrackerEx1
{
    internal class Program
    {
        static string[] tasks = new string[10];
        static int taskIndex = 0;
        //Add Method
        private static void AddTask()
        {
            Console.WriteLine("=======================");
            Console.Write("Enter Task Name : ");
            string? task = Console.ReadLine();
            tasks[taskIndex] = task;
            Console.WriteLine("=======================");
            Console.WriteLine("Task Added Successfully!");
            Console.WriteLine("=======================");
            taskIndex++;
        }
        //Delete Method
        private static void DeleteTask()
        {
            Console.WriteLine("=======================");
            Console.Write("Enter Task Number : ");
            int taskArrayIndex = int.Parse(Console.ReadLine());
            tasks[taskArrayIndex-1] = string.Empty;
            Console.WriteLine("=======================");
            Console.WriteLine("Task Deleted Successfully!");
            Console.WriteLine("=======================");
        }
        //View Method
        private static void ViewTasks()
        {
            Console.WriteLine("=======================");
            foreach (var task in tasks)
            {
                Console.WriteLine($"=> {task} <=");
            }
            Console.WriteLine("=======================");
        }
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("=======================");
            Console.WriteLine("Welcome To Task Tracker");
            Console.WriteLine("=======================");

            // Username Input
            Console.Write("Enter Your Username" +
                "\n>> ");
            string userName = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine($"Hello {userName} !");
            Console.WriteLine("=======================");
            bool isFinished = false;
            // User Choice Input 
            do
            {
                Console.Write("Choose From : \n1)Add New Task" +
                    "\n2)Delete Task " +
                    "\n3)View Tasks " +
                    "\n4)Exit Tracker " +
                    "\n>> ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Add
                        AddTask();
                        break;
                    case "2":
                        //Delete
                        DeleteTask();
                        break;
                    case "3":
                        //View
                        ViewTasks();
                        break;
                    case "4":
                        isFinished = true;
                        break;
                    default:
                        Console.WriteLine("=======================");
                        Console.WriteLine("Enter From Above Choices");
                        Console.WriteLine("=======================");
                        break;
                }
            }
            while (!isFinished);
        }
    }
}