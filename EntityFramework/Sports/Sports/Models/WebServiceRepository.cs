using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sports.Models
{
    public class WebServiceRepository : IWebServiceRepository
    {
        private DataContext context;

        public WebServiceRepository(DataContext ctx) => context = ctx;

        public void DeleteProduct(long id)
        {
            context.Products.Remove(new Product { Id = id });
        }

        public object GetProduct(long id)
        {
            return context.Products
                .Include(p => p.Category)
                .Select(p => new { Id = p.Id, Name = p.Name, Description = p.Description, PurchasePrice = p.PurchasePrice, RetailPrice = p.RetailPrice, CategoryId = p.CategoryID, Category = new { Id = p.CategoryID, Name = p.Category.Name, Descripton = p.Category.Description } })
                .FirstOrDefault(p => p.Id == id);
        }

        public object GetProducts(int skip, int take)
        {
            return context.Products
                .Include(p => p.Category)
                .OrderBy(p => p.Id)
                .Skip(skip)
                .Take(take)
                .Select(p => new { Id = p.Id, Name = p.Name, Description = p.Description, PurchasePrice = p.PurchasePrice, RetailPrice = p.RetailPrice, CategoryId = p.CategoryID, Category = new { Id = p.CategoryID, Name = p.Category.Name, Descripton = p.Category.Description } });

        }

        public long StoreProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product.Id;
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}
