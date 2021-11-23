using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    class Product : IComparable
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Nome: {Name} \nPreço: {Price}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error.");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
            
        }
    }
}
