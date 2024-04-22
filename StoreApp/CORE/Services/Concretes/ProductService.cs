using Core.DataBase;
using Core.Model;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concrets
{
    public class ProductService:IProduct
    {

        public void AddProduct(Product product)
        {
            AppDb.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = AppDb.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) throw new NullReferenceException("Product not found!");
            AppDb.Products.Remove(product);
        }

        public List<Product> GetAllProducts(Predicate<Product> predicate)
        {
            if (predicate == null)
            {
                return AppDb.Products;
            }
            return AppDb.Products.FindAll(predicate);
        }

        public Product GetProduct(Predicate<Product> predicate)
        {
            if (predicate == null)
                return AppDb.Products.FirstOrDefault();
            return AppDb.Products.Find(predicate);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            Product findProduct = AppDb.Products.Find(x => x.Id == id);

            if (findProduct != null)
            {
                findProduct.Name = newProduct.Name;
                findProduct.Description = newProduct.Description;
                findProduct.Price = newProduct.Price;
                findProduct.DiscountPercet = newProduct.DiscountPercet;
            }
        }
    }
}
