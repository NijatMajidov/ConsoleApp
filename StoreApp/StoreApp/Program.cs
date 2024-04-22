using Core.Controllers;
using Core.Enums;
using Core.Model;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController ProductController = new ProductController();
            bool check = true;
            int choise;
            Console.WriteLine("~~~~~~~~~~~~~~MENU~~~~~~~~~~~~~~~");
            do
            {
                Console.WriteLine("\n1. AddProduct\n" +
                    "2. UpdateProduct\n       " +
                    "3. DeleteProduct\r\n        " +
                    "4. ShowProduct\r\n        " +
                    "5. ShowAllProduct\n" +
                    "0. Exit\n");
                
                Console.WriteLine("Enter product id :");
                while (!int.TryParse(Console.ReadLine(), out choise) || choise < 0)
                {
                    Console.WriteLine("Please enter the correct id: ");
                }
                
                switch (choise)
                {
                    case (int) Menu.AddProduct:
                        ProductController.AddProduct();
                        break;
                    case (int)Menu.UpdateProduct:
                        ProductController.UpdateProduct();
                        break;
                    case (int)Menu.DeleteProduct:
                        ProductController.DeleteProduct();
                        break;
                    case (int)Menu.ShowProduct:
                        ProductController.AddProduct();
                        break;
                    case (int)Menu.ShowAllProduct:
                        ProductController.AddProduct();
                        break;
                }
                

            } while (check);
        }
    }
}