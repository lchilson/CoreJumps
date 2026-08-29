namespace MyStore.Products
{
    // INHERITANCE: a derived type extends a base type
    public class DigitalProduct : Product
    {
        public string DownloadUrl { get; set; }

        // Call the base class constructor with ': base(...)'
        public DigitalProduct(string name, decimal price, string downloadUrl)
            : base(name, price)
        {
            DownloadUrl = downloadUrl;
        }

        // Override a virtual method to provide specialized behavior
        public override decimal CalculateTax(decimal taxRate)
        {
            // Digital products might be taxed differently; this is just an example.
            return Price * 0.03m; // lower tax rate in this demo
        }
    }
}
