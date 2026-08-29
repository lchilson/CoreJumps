using System.Collections.Generic;

namespace MyStore.Products
{
    // INTERFACE: a contract describing expected behavior without implementation details
    public interface IProductRepository
    {
        Product? GetById(int id);
        void Save(Product product);
    }

    // A tiny in-memory implementation of the interface for demo/testing
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _store = new();
        private int _nextId = 1;

        public Product? GetById(int id)
        {
            return _store.Find(p => p.Id == id);
        }

        public void Save(Product product)
        {
            if (product.Id == 0)
            {
                product.Id = _nextId++;
                _store.Add(product);
            }
            else
            {
                // Replace existing (simple sample behavior)
                var existing = GetById(product.Id);
                if (existing != null)
                {
                    _store.Remove(existing);
                    _store.Add(product);
                }
                else
                {
                    _store.Add(product);
                }
            }
        }
    }
}
