var familyPersons = new List<Family>();
familyPersons.Add(new Family("Mamdouh Hassan" , 59 , Role.Father));
familyPersons.Add(new Family("Osama Hassan" , 55 , Role.Father));
familyPersons.Add(new Family("Mohamed Hassan" , 49 , Role.Father));
familyPersons.Add(new Family("Safaa Mahmoud" , 56 , Role.Mother));
familyPersons.Add(new Family("Eman Mohamed" , 49 , Role.Mother));
familyPersons.Add(new Family("Shimaa Mohamed" , 41 , Role.Mother));

NameSorting nameSorting = new NameSorting();
familyPersons.Sort(nameSorting);

foreach (var p in familyPersons)
{
    Console.WriteLine("============");
    Console.WriteLine($"Name : {p.FullName}");
    Console.WriteLine($"Age : {p.Age}");
    Console.WriteLine($"Role : {p.Role}");
}

Console.WriteLine("========ENUM TO LIST========");
//Casting Enums into Lists 
var enumList = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
foreach (var item in enumList)
{
    Console.WriteLine(item);
}
// Copying List
var list = new List<string>()
{
    "Al-Ahly",
    "Zamalek",
    "Pyramids",
    "Ismaily",
    "Zed"
};
var newList = new List<string>(list);
var newAnotherList = list.ToList();

Console.ReadKey();

public class Family
//: IComparable<Family>
{
    public int Age { get; set; }
    public string? FullName { get; set; }
    public Role Role { get; set; }

    public Family(string name , int age , Role role)
    {
        this.FullName = name;
        this.Age = age;
        this.Role = role;
    }

    //public int CompareTo(Family family) 
    //{
    //    //Decending Sort
    //    if (this.Age > family.Age) return -1;
    //    else if (this.Age < family.Age) return 1;
    //    else return 0;
    //}
    
}
public class NameSorting : IComparer<Family> 
{
    public int Compare(Family x ,Family y) 
    {
        return x.FullName.CompareTo(y.FullName);
    }
}
public enum Role 
{
    Father,
    Mother,
    Daughter,
    Son,
    Child
}

// In Sorting Complex Types => Sort Method Depends on other interfaces Like { IComparer , IComparable } which you can define and use it's methods.