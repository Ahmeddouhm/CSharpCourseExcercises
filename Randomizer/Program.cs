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
            GenerateNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            break;
        case "2":
            GenerateString();
            break;
        case "ex":
            isFinished = true;
            break;
        default:
            break;
    }
} while (!isFinished);
static void GenerateNumber(int min , int max) 
{
    Random rnd = new Random();
    int value = rnd.Next(min, max);
    Console.WriteLine($"Number is {value}");
}
static void GenerateString() 
{
    Random rnd = new Random();
    var sb = new StringBuilder();
    while (sb.Length < 5)
    {
        sb.Append((char)(rnd.Next(0, 2) == 0 ? rnd.Next(65, 91) : rnd.Next(97, 123)));
    }
    Console.WriteLine($"String is {sb}");
}