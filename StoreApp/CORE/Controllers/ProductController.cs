using Core.DataBase;
using Core.Model;
using Core.Services.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class ProductController
    {
        ProductService ProductService = new ProductService();

        public void AddProduct()
        {
            Console.WriteLine("Create new product");
            Console.Write("Enter product name: ");
            string name = Console.ReadLine ();

            Console.WriteLine("Enter product description: ");
            string descrip = Console.ReadLine ();

            double price;
            Console.WriteLine("Enter product price :");
            while (!double.TryParse(Console.ReadLine(), out price) || price < 0){
                Console.WriteLine("Please enter the correct price");
            }

            byte discountParcet;
            Console.WriteLine("Enter product price :");
            while (!byte.TryParse(Console.ReadLine(), out discountParcet) || discountParcet < 0)
            {
                Console.WriteLine("Please enter the correct price: ");
            }

            Product product = new Product(name, descrip, price, discountParcet);

            ProductService.AddProduct(product);
        }

        public void DeleteProduct()
        {
            int id;
            Console.WriteLine("Enter product id :");
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0 )
            {
                Console.WriteLine("Please enter the correct id: ");
            }
            try
            {
                ProductService.DeleteProduct(id);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateProduct()
        {
            int id;
            Console.WriteLine("Enter product id :");
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("Please enter the correct id: ");
            }

            Console.WriteLine("Update product");
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product description: ");
            string descrip = Console.ReadLine();

            double price;
            Console.WriteLine("Enter product price :");
            while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Please enter the correct price");
            }

            byte discountParcet;
            Console.WriteLine("Enter product price :");
            while (!byte.TryParse(Console.ReadLine(), out discountParcet) || discountParcet < 0)
            {
                Console.WriteLine("Please enter the correct price: ");
            }
            Product newProduct = new Product(name, descrip, price, discountParcet);

            ProductService.UpdateProduct(id, newProduct);
        }

        public void GetProduct(int id)
        {
            Console.WriteLine("Enter product id :");
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("Please enter the correct id: ");
            }
            ProductService.GetProduct(x => x.Id == id);
        }
        public void GetAllProduct(int id)
        {
            Console.WriteLine("Enter product id :");
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("Please enter the correct id: ");
            }
            ProductService.GetProduct(x => x.Id == id);
        }
    }
}
