namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess
{
    public List<Products> DatabaseList { get; set; } = new List<Products>();

    public List<Products> LoadData()
    {
        Console.WriteLine("I am reading data from SQL Database");
        return DatabaseList;
    }
    public void SaveData(Products data)
    {
        Console.WriteLine($"I am saving {data.Name} to SQL Database");
        DatabaseList.Add(data);
    }
}