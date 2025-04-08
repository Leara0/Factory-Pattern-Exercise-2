using System.Collections.Generic;


namespace FactoryPatternExercise2


{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What database would you like to use? (List, SQL or Mongo)");
            var response = Console.ReadLine();
            var Database = DataAccessFactory.GetDataAccessType(response);
            bool addAnotherProduct;


            do //adding a product to the database
            {
                Console.WriteLine("What product would you like to add to this database?");
                var product1 = new Products()
                    { Name = Console.ReadLine() };

                var validResponse = false;
                do
                {
                    Console.WriteLine("What is the price for this product? (Please enter a valid integer)");
                    int price;
                    if (int.TryParse(Console.ReadLine(), out price))
                    {
                        product1.Price = price;
                        validResponse = true;
                    }
                } while (!validResponse);

                Database.SaveData(product1);

                Console.WriteLine("Would you like to add another product? (Y/N)");
                response = Console.ReadLine();
                addAnotherProduct = response.ToUpper() == "Y";
            } while (addAnotherProduct);

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //reviewing the products added to the database
            List<Products> productsList = Database.LoadData();

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i+1}. - {productsList[i].Name} {productsList[i].Price:C}");
            }
        }
    }
}