using ProductMicroservice.Models;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(Product Product);
        void UpdateProduct(Product Product);

        void Save();
        void DeleteProduct(int id);
    }
}
