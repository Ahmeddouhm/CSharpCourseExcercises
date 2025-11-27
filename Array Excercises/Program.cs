#region Traversing Array
//char[] genders = {
//    'm', 'f', 'm', 'f',
//    'm', 'm', 'm', 'f',
//    'm', 'm', 'f', 'f'
//};
//int male = 0 , female =0;
//foreach (char gender in genders)
//{
//   _ = gender == 'm' ? male++ : female++;
//}
//Console.WriteLine($"{male} Males , {female} Females");
#endregion

#region Find Maximum Number (The Hard Way)
//int[] numbers = { 452, 849, 511, 685, 247, 954 , 777 , 189 , 587};
//int maxNumber = 0 , minNumber = 0;
//maxNumber = numbers[0];
//minNumber = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//	if (numbers[i] > maxNumber)
//	{
//		maxNumber = numbers[i];
//	}
//	if (numbers[i] < minNumber)
//	{
//		minNumber = numbers[i];
//	}
//}
//Console.WriteLine($"Max is {maxNumber} , Min is {minNumber}");
#endregion

#region Find Maximum Number (The Easy Way)
//int[] numbers = { 452, 849, 511, 685, 247, 954, 777, 189, 587 };
//numbers.Sort();
//Console.WriteLine($"Max is {numbers[numbers.Length-1]} , Min is {numbers[0]}");
//Console.WriteLine($"Max is {numbers.Max()} , Min is {numbers.Min()}");
#endregion

#region Bubble Sort
//int[] numbers = { 5,4,2,1,7,8,3,6,9 };
//int swap = 0;
//Console.WriteLine("Before Sorting");
//foreach (var num in numbers)
//{
//	Console.Write($"{num} , ");
//}
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//	for (int j = 0; j < numbers.Length - 1 - i; j++)
//	{
//		if (numbers[j] > numbers[j+1])
//		{	//But smaller into swap{Temp}
//			swap = numbers[j+1];
//			//Copy bigger into second => first and second will have same value
//			numbers[j+1] = numbers[j];
//			//But smaller into first
//			numbers[j] = swap;
//		}
//	}
//}
//Console.WriteLine("After Sorting");
//foreach (var num in numbers)
//{
//    Console.Write($"{num} , ");
//}
#endregion

#region 2D Array
//int[,] twoDimArray = { {1,2,3} , {4,5,6} , {7,8,9} , {0,0,0} };
//int rows = twoDimArray.GetLength(0);
//int cols = twoDimArray.GetLength(1);
////Program to Print Phone Numbers
//for (int i = 0; i < rows; i++)
//{
//	for (int j = 0; j < cols; j++)
//	{
//		if (i == 3)
//		{
//			Console.WriteLine($"  {twoDimArray[3,1]}");
//			break;
//		}
//		else
//		{
//            Console.Write($"{twoDimArray[i, j]} ");
//        }
//    }
//    Console.WriteLine();
//}
#endregion

#region Jagged Array
//int[][] jaggedArray =
//{
//    new int[] {1,2,3},
//    new int[] {4,5,6},
//    new int[] {7,8,9}
//};
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Console.Write($"{jaggedArray[i][j]} ");
//    }
//    Console.WriteLine();
//}
#endregion