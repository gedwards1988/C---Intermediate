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
            FilteredIncludes();

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

                /////////////////////// Practice ////////////////////////////////////
                foreach (Category c in categories)
                {
                    Console.WriteLine($"Category {c.CategoryId}. {c.CategoryName} - {c.Description}");
                }

                IQueryable<Product>? products = db.Products?
                    .Include(p => p.Category);

                foreach (Product p in products)
                {
                    Console.WriteLine($"{p.Category.CategoryName} - {p.ProductName}");
                }

                foreach (Category c in categories)
                {
                    if (c.Products.Count > 10)
                    {
                        Console.WriteLine("Large Volume Products");
                        Console.WriteLine($"{c.CategoryName} - {c.Products.Count}");
                    }
                    else
                    {
                        Console.WriteLine("Low Volume Products");
                        Console.WriteLine($"{c.CategoryName} - {c.Products.Count}");
                    }
                }
            }
        }

        static void FilteredIncludes()
        {
            using (Northwind db = new())
            {
                Console.WriteLine("Enter a minimum for units in stock: ");
                string? unitsInStock = Console.ReadLine();
                int stock = int.Parse(unitsInStock);

                IQueryable<Category>? categories = db.Categories?
                    .Include(c => c.Products.Where(p => p.Stock >= stock));

                if (categories is null)
                {
                    Console.WriteLine("No Categories Found!");
                    return;
                }

                foreach (Category c in categories)
                {
                    Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products with a" +
                        $" minimum stock of {stock} units in stock");

                    foreach (Product p in c.Products)
                    {
                        Console.WriteLine($"\t{p.ProductName} has {p.Stock} units in stock");
                    }

                }

            }
        }
        /// end


    }
}