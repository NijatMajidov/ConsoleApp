using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface IProduct
    {
        void AddProduct(Product product);
        void UpdateProduct(int id, Product newProduct);
        void DeleteProduct(int id);
        Product GetProduct(Predicate<Product> predicate);
        List<Product> GetAllProducts(Predicate<Product> predicate);
    }
}
