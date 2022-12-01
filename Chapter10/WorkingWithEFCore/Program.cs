using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace WorkingWithEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Using {ProjectConstants.DatabaseProvider} database provider");

            //QueryingCategories();
            // FilteredIncludes();
            // QueryingProducts();
            QueryingWithLike();

        }

        static void QueryingCategories()
        {
            using (Northwind db = new ())
            {

                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory> ();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

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
                /* foreach (Category c in categories)
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
                }*/
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
        /// 

        static void QueryingProducts()
        {
            using (Northwind db = new())
            {

                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Console.WriteLine($"Products that have more than a number in stock, hightest at top");
                string? input;
                int stocks;

                do
                {
                    Console.WriteLine("Enter a stock level: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out stocks));

                IQueryable<Product>? products = db.Products?
                    .Where(product => product.Stock > stocks)
                    .OrderByDescending(product => product.Stock);

                if (products is null)
                {
                    Console.WriteLine("No products Found!");
                    return;
                }

                foreach (Product p in products)
                {
                    Console.WriteLine(
                        "{0}: {1} has {2} in stock, which is more than {3}",
                        p.ProductId, p.ProductName, p.Stock, stocks);
                }

            }
        }
        /// end
        /// 

        static void QueryingWithLike()
        {
            using (Northwind db = new())
            {
                ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Console.WriteLine("Enter part of product name: ");
                string? input = Console.ReadLine();

                IQueryable<Product>? products = db.Products?
                    .Where(p => EF.Functions.Like(p.ProductName, $"%{input}%"));


                if (products is null)
                {
                    Console.WriteLine("No product found!");
                    return;
                }

                foreach (Product p in products)
                {
                    Console.WriteLine("{0} has {1} units in stock.  Discontinued {2}",
                        p.ProductName, p.Stock, p.Discontinued);
                }

            }
        }
        /// end
        /// 
    }
}