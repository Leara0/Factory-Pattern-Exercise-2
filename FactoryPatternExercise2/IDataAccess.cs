namespace FactoryPatternExercise2;

public interface IDataAccess
{
    public List<Products> DatabaseList { get; set; }
    public List<Products> LoadData();
    public void SaveData(Products data);
}