//  Triangle
//for (int i = 0; i <= 10; i++) 
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine("");
//}
//  Reversed Triangle
//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 10; j >= i; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine("");
//}

//  Pyramid
//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 10; j >= i; j--)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(" *");
//    }
//    Console.WriteLine("");
//}

//  Reversed Pyramid
//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 10; j >= i; j--)
//    {
//        Console.Write(" *");
//    }
//    Console.WriteLine("");
//}

//  Hollow Pyramid
for (int i = 0; i <= 10; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i || i == 10 - 1)
        {
        Console.Write("*");
        }
        else
        {
        Console.Write(" ");
        }
    }
    Console.WriteLine("");    
}
/*
 
*
* *
*  *
*   *
*    *
*     *
********    
 
*/
