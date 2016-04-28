using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Products
{
    public class Food : ISellable
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Food(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Name}, € {this.Price.ToString("0.00")}";
        }
    }
}
