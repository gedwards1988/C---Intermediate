using Packt.Shared;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Using {ProjectConstants.DatabaseProvider} database provider");

            QueryingCategories();

        }

        static void QueryingCategories()
        {
            using (Northwind db = new ())
            {
                Console.WriteLine("Categories and how many products they have:");

                // Query to get all products in each category
                IQueryable<Category>? categories = db.Categories?
                    .Include(c => c.Products);

                if (categories == null)
                {
                    Console.WriteLine("No categories found .....");
                    return;
                }

                foreach (Category c in categories)
                {
                    Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products");
                }

            }
        }

    }
}