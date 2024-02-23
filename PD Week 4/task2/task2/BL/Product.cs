using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Product
    {
        public string name;
        public string category;
        public int price;

        public double calculateTax()
        {
            double tax = price * 0.1;
            return tax;
        }
    }
}
