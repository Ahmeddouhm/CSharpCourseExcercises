string myName = "   Ahmed Mamdouh hassn";

//Trim
Console.WriteLine(myName.Trim());
//Length
Console.WriteLine(myName.Trim().Length);
//Replace
Console.WriteLine(myName.Replace(" " , "."));
//IndexOf
Console.WriteLine(myName.IndexOf('a'));
//LastIndexOf
Console.WriteLine(myName.LastIndexOf('h'));
//Substring
Console.WriteLine(myName.Substring(3));
//Remove
Console.WriteLine(myName.Remove(8));
//Uppercase
Console.WriteLine(myName.ToUpper());
//Lowercase
Console.WriteLine(myName.ToLower());
//Contains
Console.WriteLine(myName.Contains("Ahmed"));
//Insert
Console.WriteLine(myName.Insert(21 ,"a"));
//Split
var x = myName.Split(" ");
Console.WriteLine(x);
