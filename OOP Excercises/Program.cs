using OOP_Excercises;

Person p1 = new Person(
    fname: "Ahmed" ,
    lname: "Mamdouh" ,
    age: 19 ,
    salary: 17000 ,
    children: 2 
    );
Console.WriteLine($"{p1}");
//Console.WriteLine($"Name : {p1.FirstName} {p1.LastName} ,\nAge : {p1.Age} ,\nChildren : {p1.Children} ,\nSalary : {p1.Salary}");

Console.ReadKey();