using System;

namespace MyStore.Products
{
    // A simple class demonstrating fields, properties, constructor and methods.
    public class Product
    {
        // FIELD: stored data inside the class
        private decimal _cost; // private: only code inside this class can access it

        // PROPERTY: public surface for external code to read/write
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        // Status using the ProductStatus enum to avoid invalid string values
        public ProductStatus Status { get; set; } = ProductStatus.Draft;

        // Property that wraps the private field. This shows how fields and properties relate.
        public decimal Cost
        {
            get => _cost;
            set => _cost = value;
        }

        // CONSTRUCTOR: how you create (initialize) an instance
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // METHOD: behavior of the class
        // 'virtual' means derived classes can override this implementation.
        public virtual decimal CalculateTax(decimal taxRate)
        {
            return Price * taxRate;
        }

        public decimal CalculateTotal(decimal taxRate)
        {
            // Local variables: only visible inside this method
            decimal tax = CalculateTax(taxRate);
            decimal total = Price + tax;
            return total; // return statement exits the method and produces a value
        }

        public decimal CalculateProfit()
        {
            decimal profit = Price - _cost; // uses the private field
            return profit;
        }
    }
}
