CRUDApp app1 = new CRUDApp();
app1.ConnectDatabase();

class CRUDApp 
{
    string connectionString = null;
    public void ConnectDatabase() 
    {
        if (connectionString==null)
        {
            throw new DatabaseNotFoundException();
        }
    }
}

class DatabaseNotFoundException : ApplicationException 
{
    public DatabaseNotFoundException()
    {
        Console.WriteLine("Database Connection Failed => Database Not Found || Custom Exception");
    }
}