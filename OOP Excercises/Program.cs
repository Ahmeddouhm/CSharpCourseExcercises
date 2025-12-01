using OOP_Excercises;

Person p1 = new Person(
    fname: "Ahmed" ,
    lname: "Mamdouh" ,
    age: 19 ,
    salary: 17000 ,
    children: 2 
    );

BankAccount acc1 = new BankAccount("1" , "54615484984" , "Ahmed Mamdouh" , 10000);
BankAccount acc2 = new BankAccount("2" , "54615454561" , "Mohamed Mamdouh" , 3240);
BankAccount acc3 = new BankAccount("3" , "54615454561" , "Hassan Mamdouh" , 9640);
BankAccount acc5 = new BankAccount("4" , "54615454561" , "Fares Mamdouh" , 8450);
acc1.ViewBalance();
acc1.Deposit(325);
acc2.Withdraw(400);
Console.WriteLine(BankAccount.OnlineUsers);


Console.WriteLine($"{p1}");

Console.ReadKey();