using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Products;

namespace Repository
{
    public class Webshop
    {
        public List<ISellable> Products { get; private set; }

        public Webshop()
        {
            this.Products = new List<ISellable>();
        }

        public void AddProduct(ISellable product)
        {
            this.Products.Add(product);
        }
    }
}
