using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Customer
    {
        public string customerName;
        public string customerAdress;
        public string customerContact;
        public List<Product> products = new List<Product>();

        public List<Product> getAllProducts()
        {
            return products; 
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
}
