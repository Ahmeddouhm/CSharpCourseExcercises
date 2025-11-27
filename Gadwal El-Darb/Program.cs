//Gadwal El-Darb using For Loop
//for (int i = 0; i <= 10 ; i++)
//{
//    Console.WriteLine($"Gadwal {i}");
//    for (int j = 0; j <= 12 ; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i*j}");
//    }
//    Console.WriteLine("---------------------------");
//}
//Gadwal El-Darb using While Loop
int i = 0;
while (i <= 12) 
{
    Console.WriteLine($"Gadwal {i}");
    int j = 0;
    while (j <= 12)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
        j++;
    }
    i++;
    Console.WriteLine("---------------------------");
}