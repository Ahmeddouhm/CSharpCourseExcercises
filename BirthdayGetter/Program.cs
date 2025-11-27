//Get From User
DateOnly userDate = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(userDate.DayOfWeek);
//Another Format
Console.WriteLine($"{userDate:dddd} of Month {userDate:MMMM} Year {userDate:yyyy}");
Console.ReadKey();
