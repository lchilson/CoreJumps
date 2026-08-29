using System;
using MyStore.Products;

/*
 Reference demo for later in the learning path.
 Run with: dotnet run --project CSharpBasics

 This file intentionally shows many C# ideas together so you can see
 how they connect after the basics are already understood.

 Early lessons should focus on smaller steps: variables, conditions,
 loops, methods, and object state before trying to understand the
 full example in one pass.
*/

namespace MyStore.Demo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("--- C# Basics Demo ---\n");

            // 1) Create an instance (object) of Product using the constructor
            var keyboard = new Product("Keyboard", 49.99m);
            keyboard.Cost = 20.00m; // set a private-backed value via public property

            // 2) Use a property (public surface of the object)
            Console.WriteLine($"Product: {keyboard.Name} — Price: {keyboard.Price}");

            // 3) Call a method with a parameter (taxRate is a parameter)
            var tax = keyboard.CalculateTax(0.06m); // 0.06m is the argument
            Console.WriteLine($"Tax for {keyboard.Name}: {tax:C}");

            // 4) Local variables are inside methods
            var total = keyboard.CalculateTotal(0.06m);
            Console.WriteLine($"Total: {total:C}\n");

            // 5) Static usage: no instance required
            var staticTax = TaxCalculator.Calculate(100m);
            Console.WriteLine($"Static tax for $100: {staticTax:C}\n");

            // 6) Enums: safer than plain strings
            keyboard.Status = ProductStatus.Active;
            Console.WriteLine($"Status: {keyboard.Status}\n");

            // 7) Inheritance: derived class extends behavior
            var eBook = new DigitalProduct("E-Book", 9.99m, "https://download.example/book123");
            Console.WriteLine($"Digital product: {eBook.Name}, URL: {eBook.DownloadUrl}");
            Console.WriteLine($"Digital product tax: {eBook.CalculateTax(0.06m):C}\n");

            // 8) Interfaces: use the contract instead of a concrete class
            IProductRepository repo = new InMemoryProductRepository();
            repo.Save(keyboard);
            var loaded = repo.GetById(1);
            Console.WriteLine($"Loaded from repo: {loaded?.Name} (id={loaded?.Id})\n");

            Console.WriteLine("Demo complete. Explore the source files to learn more.");
        }
    }
}
