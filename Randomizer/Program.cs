using System.Text;

Console.WriteLine("=====================");
Console.WriteLine("Welcome To Randomizer");
Console.WriteLine("=====================");
bool isFinished = false;
do
{
    Console.Write("Select Random Type " +
        "\n1) Number" +
        "\n2) String" +
        "\n>> ");
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.Write("Enter Min Number : ");
            int minNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Max Number : ");
            int maxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
            GenerateNumber(minNumber, maxNumber);
            break;
        case "2":
            Console.Write("Enter String Length : ");
            int stringLength = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
            GenerateString(stringLength);
            break;
        case "ex":
            isFinished = true;
            break;
        default:
            Console.WriteLine("=====================");
            Console.WriteLine("Enter A Valid Command !");
            Console.WriteLine("=====================");
            break;
    }
} while (!isFinished);
static void GenerateNumber(int min , int max) 
{
    Random rnd = new Random();
    int value = rnd.Next(min, max);
    Console.WriteLine($"Number is {value}");
    Console.WriteLine("=====================");
}
static void GenerateString(int stLn) 
{
    Random rnd = new Random();
    var sb = new StringBuilder();
    while (sb.Length < stLn)
    {
        sb.Append((char)(rnd.Next(0, 2) == 0 ? rnd.Next(65, 91) : rnd.Next(97, 123)));
    }
    Console.WriteLine($"String is {sb}");
    Console.WriteLine("=====================");
}