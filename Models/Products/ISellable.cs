using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Products
{
    public interface ISellable
    {
        string Name { get; }
        decimal Price { get; }
    }
}
