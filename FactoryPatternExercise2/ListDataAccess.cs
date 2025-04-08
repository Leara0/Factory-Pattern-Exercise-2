namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    public List<Products> DatabaseList { get; set; } = new List<Products>();

    public List<Products> LoadData()
    {
        Console.WriteLine("I am reading data from List Database");
        return DatabaseList;
    }
    public void SaveData(Products data)
    {
        Console.WriteLine($"I am saving {data.Name} to List Database");
        DatabaseList.Add(data);
    }
}