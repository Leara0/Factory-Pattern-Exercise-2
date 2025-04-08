namespace FactoryPatternExercise2;

public static class ProductFactory
{
    public static Products CreateProduct(string Name)
    {
        return new Products();
    }

    public static void SetPrice(int Price)
    {
        
    }
}