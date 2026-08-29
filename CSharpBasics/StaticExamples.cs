namespace MyStore.Products
{
    // STATIC: no instance required — common helpers often use static members
    public static class TaxCalculator
    {
        public static decimal Calculate(decimal price)
        {
            const decimal taxRate = 0.06m; // const: compile-time constant
            return price * taxRate;
        }
    }
}
