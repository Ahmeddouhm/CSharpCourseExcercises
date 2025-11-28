
#region Make Your Pyramid Shape

//Console.WriteLine("===========================");
//Console.WriteLine("Welcome To Pyramid Designer");
//Console.WriteLine("===========================");
//Console.Write("Enter Pyramid Side Value : ");
//int side = Convert.ToInt32(Console.ReadLine());

//DesignPyramid(side);

//static void DesignPyramid(int side)
//{
//	for (int i = 0; i <= side; i++)
//	{
//		for (int j = side; j >= i ; j--)
//		{
//			Console.Write(" ");
//		}
//		for (int k = 0; k < i; k++)
//		{
//            Console.Write(" *");
//		}
//        Console.WriteLine();
//	}
//	Console.ReadKey();
//}
#endregion

#region Sort Array!
Console.WriteLine("===========================");
Console.WriteLine("Welcome To Sort Array!");
Console.WriteLine("===========================");
Console.Write($"Enter Array Size : ");
int arrSize = Convert.ToInt16(Console.ReadLine());
Console.Write($"Enter Array Range Of Values : ");
int arrRangeOfValues = Convert.ToInt16(Console.ReadLine());
CreateRandomArray(arrSize , arrRangeOfValues);
static void CreateRandomArray(int arrSize , int arrRangeOfValues)
{
    Random rand = new Random();
    int[] arr = new int[arrSize];
    int[] userArray = new int[arrSize];
    //Create Random Array
    for (int i = 0; i < arr.Length; i++)
    {
        int numToCheck;
        //Check The Randomize Of Values
        do
        {
            numToCheck = rand.Next(1,arrRangeOfValues);

        } while (arr.Contains(numToCheck));

        arr[i] = numToCheck;
        Console.Write($"[{arr[i]}] ");
    }
    //Input From User
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"\nEnter index[{i}] : ");
        userArray[i] = Convert.ToInt16(Console.ReadLine());
        foreach (var item in userArray)
        {
            Console.Write($"{item} ");
        }
    }
    //Vaildate User Input
    Array.Sort(arr);
    for (int i = 0; i < userArray.Length; i++)
    {
        if (arr[i] == userArray[i])
        {
            Console.Write($"\nindex[{i}] True ");
        }
        else
        {
            Console.Write($"\nindex[{i}] False ");
        }
    }
}
#endregion