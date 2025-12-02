// Welcome Message
Console.WriteLine("=======================");
Console.WriteLine("Welcome To Task Tracker");
Console.WriteLine("=======================");
Console.WriteLine("Enter Your Username");
string userName = Console.ReadLine();
Console.WriteLine("=======================");
Console.WriteLine($"Hello {userName} !");
Console.WriteLine("=======================");
do
{
    Console.WriteLine("Choose From : \n1)Add New Task" +
	    "\n2)Delete Task " +
	    "\n3)View Tasks " +
	    "\n4)Exit Tracker \n=>");
    bool isValid = false;
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            //Add
            isValid = true;
            break;        
        case "2":
            //Delete
            isValid = true;
            break;        
        case "3":
            //View
            isValid = true;
            break;
        default:
            Console.WriteLine("Enter From Above Choices");
            break;
    }
}
while (!isValid);
//Add
//Delete
//View
//Exit
