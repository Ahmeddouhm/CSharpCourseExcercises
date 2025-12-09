
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
//Console.WriteLine("===========================");
//Console.WriteLine("Welcome To Sort Array!");
//Console.WriteLine("===========================");
//Console.Write($"Enter Array Size : ");
//int arrSize = Convert.ToInt16(Console.ReadLine());
//Console.Write($"Enter Array Range Of Values : ");
//int arrRangeOfValues = Convert.ToInt16(Console.ReadLine());
//CreateRandomArray(arrSize , arrRangeOfValues);
//static void CreateRandomArray(int arrSize , int arrRangeOfValues)
//{
//    Random rand = new Random();
//    int[] arr = new int[arrSize];
//    int[] userArray = new int[arrSize];
//    //Create Random Array
//    for (int i = 0; i < arr.Length; i++)
//    {
//        int numToCheck;
//        //Check The Randomize Of Values
//        do
//        {
//            numToCheck = rand.Next(1,arrRangeOfValues);

//        } while (arr.Contains(numToCheck));

//        arr[i] = numToCheck;
//        Console.Write($"[{arr[i]}] ");
//    }
//    //Input From User
//    for (int i = 0; i < userArray.Length; i++)
//    {
//        Console.Write($"\nEnter index[{i}] : ");
//        userArray[i] = Convert.ToInt16(Console.ReadLine());
//        foreach (var item in userArray)
//        {
//            Console.Write($"{item} ");
//        }
//    }
//    //Vaildate User Input
//    Array.Sort(arr);
//    for (int i = 0; i < userArray.Length; i++)
//    {
//        if (arr[i] == userArray[i])
//        {
//            Console.Write($"\nindex[{i}] True ");
//        }
//        else
//        {
//            Console.Write($"\nindex[{i}] False ");
//        }
//    }
//}
#endregion

#region Call By Value vs Call By Reference
//int operand1 = 5;
//int operand2 = 5;
//Console.WriteLine($"{operand1} , {operand2}");
//Console.WriteLine($"{Sum(ref operand1 , ref operand2)}");
//Console.WriteLine($"{operand1} , {operand2}");


//static int Sum(ref int op1 ,ref int op2) 
//{
//    int sum = 0;
//    op1 += 5;
//    op2 += 5;
//    sum = op1 + op2;
//    return sum;
//}
#endregion

#region Extension Methods
//string myName = "Ahmed Mamdouh Hassan Abdelwahab";
//Console.WriteLine(myName.WordCounter());
//string myNumber = "20500";
//Console.WriteLine(myNumber.IsNumber());

//static class ExtensionMethods 
//{
//    public static int WordCounter(this string text) 
//    {
//        string[] textCount = text.Split(' ');
//        return textCount.Length;
//    }

//    public static bool IsNumber(this string text) 
//    {
//        if (int.TryParse(text, out int n))
//        {
//            Console.WriteLine(n);
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

#endregion

#region Recursive Methods
//Calc Factorial nonRecursiveMethod
//Console.WriteLine(5.CalcFactorial());
//Console.WriteLine(5.CalcFactorialR());
//string path = @"D:\namespace";
//StaticMethods.DisplayFolders(path , 3);

//static class StaticMethods 
//{
//    public static int CalcFactorial(this int num) 
//    {
//        int result=1;
//        if (num > 0)
//        {
//            for (int i = num; i > 0; i--)
//            {
//                result *= i;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Enter Positive Number");
//        }

//        return result;
//    }
//    public static int CalcFactorialR(this int num) 
//    {
//        if (num > 0)
//        {
//        return num * CalcFactorialR(num - 1);
//        }
//        return 1;               
//    }

//    public static void DisplayFolders(string path, int indent)
//    {
//        foreach (var folder in Directory.GetDirectories(path))
//        {
//            Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
//            DisplayFolders(folder, indent + 1);
//        }
//    }

//}
#endregion

//#region Recursion Excercise

////5.PrintNumSequence();
//Console.WriteLine(12190.SumOfDigits());
Console.WriteLine("Ahmed".ReverseString());
//;
static class RecursionExcercise
{
    public static void PrintNumSequence(this int num)
    {
        if (num == 0)
            return;
        Console.WriteLine($"{num}");
        PrintNumSequence(num - 1);
    }

    public static int SumOfDigits(this int num)
    {
        if (num == 0)
        {
            return 0;
        }
        int lastDigit = num % 10;

        return lastDigit + SumOfDigits(num / 10); ;
    }
    public static string ReverseString(this string text)
    {
        if (text.Length <= 0)
            return string.Empty;
        return ReverseString(text.Substring(1)) + text[0];
    }
}
//#endregion