Player Mohamed_Salah = new Player("Mohamed Salah" , 33 , Nationality.Egypt , Club.Liverbool , Position.RW);
Console.WriteLine($"Player Card " +
    $"\n-------------" +
    $"\nName : {Mohamed_Salah.Name}"+
    $"\nAge : {Mohamed_Salah.Age}" +
    $"\nNationality : {Mohamed_Salah.Nationality}"+
    $"\nClub : {Mohamed_Salah.Club}"+
    $"\nPosition : {Mohamed_Salah.Position}");

public class Player 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Nationality Nationality { get; set; }
    public Club Club { get; set; }
    public Position Position { get; set; }

    public Player(string name , int age , Nationality nationality , Club club , Position position)
    {
        this.Name = name;
        this.Age = age;
        this.Nationality = nationality;
        this.Club = club;
        this.Position = position;
    }
}

public enum Nationality 
{
    Egypt,
    SouthAfrica,
    Senegal,
    Algeria,
    France,
    Germany,
    Spain
}

public enum Club 
{
    Al_Ahly,
    Al_Zamalek,
    Etoile,
    Widad,
    Real_Madrid,
    Liverbool,
    Man_City,
    Man_United,
}

public enum Position 
{
    ST,
    LW,
    RW,
    CMF,
    AMF,
    LMF,
    RMF,
    DMF,
    RB,
    LB,
    CB,
    GK,
}