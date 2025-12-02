namespace Simple_CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome To Simple CLI :)");
            bool isFinished = false;
            do
            {
                //Take User Input
                Console.Write(">> ");
                string userInput = Console.ReadLine().Trim();
                //Get Command , Path
                int splitIndex = userInput.IndexOf(' ');
                string command = userInput.Substring(0, splitIndex).ToLower();
                string path = userInput.Substring(splitIndex + 1);
                Console.WriteLine(command);
                Console.WriteLine(path);
                switch (command)
                {
                    //List Directories & Files
                    case "ls":
                        foreach (var item in Directory.GetDirectories(path.Trim()))                        
                            Console.WriteLine($"Dir : {item}");
                        foreach (var item in Directory.GetFiles(path.Trim()))
                            Console.WriteLine($"File : {item}");                        
                        break;
                    //Make Directory
                    case "mkdir":
                        Directory.CreateDirectory(path.Trim());
                        break;
                    //Remove Directory
                    case "rm":
                        Directory.Delete(path.Trim(), true);
                        break;
                    //Show File info
                    case "info":
                        if (Directory.Exists(path.Trim()))
                        {
                            var dirInfo = new DirectoryInfo(path.Trim());
                            Console.WriteLine("Directory Info :");
                            Console.WriteLine($"Created : {dirInfo.Name}");
                            Console.WriteLine($"Created : {dirInfo.CreationTime}");
                            Console.WriteLine($"Modified : {dirInfo.LastWriteTime}");
                        }
                        else
                        {
                            var fileInfo = new FileInfo(path.Trim());
                            Console.WriteLine("File Info :");
                            Console.WriteLine($"Created : {fileInfo.Name}");
                            Console.WriteLine($"Created : {fileInfo.CreationTime}");
                            Console.WriteLine($"Modified : {fileInfo.LastWriteTime}");
                        }
                        break;
                    //Exit CLI
                    case "ex":
                        isFinished = true;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Command");
                        break;
                }
            } while (!isFinished);
        }
    }
}
