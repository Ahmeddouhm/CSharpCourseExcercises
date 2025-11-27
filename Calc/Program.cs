Console.WriteLine("Enter Operator");
char userOperator = char.Parse(Console.ReadLine());
Console.Write($"Enter Operand 1 : ");
var userOperand1 = int.Parse(Console.ReadLine());
Console.Write($"Enter Operand 2 : ");
var userOperand2 = int.Parse(Console.ReadLine());

Console.WriteLine
    (userOperator switch 
    {
    '+' =>  userOperand1 + userOperand2,
    '-' =>  userOperand1 - userOperand2,
    '*' =>  userOperand1 * userOperand2,
    '/' =>  userOperand1 / userOperand2,
    }
    );



