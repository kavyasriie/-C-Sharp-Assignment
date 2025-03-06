using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual int GetDiscountedPrice(int discount)
        {
            return Price - discount;
        }
    }
    class ElectronicProduct : Product
    {
        public override int GetDiscountedPrice(int discount)
        {
            return Price - discount - 10;
        }
    }
    class ClothingProduct : Product
    {
        public override int GetDiscountedPrice(int discount)
        {
            return Price - discount - 5;
        }
    }
}
