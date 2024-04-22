using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Product
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte DiscountPercet { get; set; }

        public Product(string name, string descrip, double price, byte disPer)
        {
            Id = ++_id;
            Name = name;
            Description = descrip;
            Price = price;
            DiscountPercet = disPer;
        }

        public override string ToString()
        {
            return $"Name: {Name} Description: {Description} Price: {Price} DiscountPercet: {DiscountPercet}";
        }
    }
}
