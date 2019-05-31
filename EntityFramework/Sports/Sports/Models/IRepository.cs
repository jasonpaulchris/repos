using Sports.Models.Pages;
using System.Collections.Generic;

namespace Sports.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        PagedList<Product> GetProducts(QueryOptions options, long category = 0);
        Product GetProduct(long key);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void UpdateAll(Product[] products);
        void Delete(Product product);
    }
}
