using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Product product1 = new Product();
            product1.name = "egg";
            product1.price = 100;
            customer.addProduct(product1);
            customer.getAllProducts();
            Console.WriteLine(customer.products[0].name);
            Console.WriteLine(product1.calculateTax());
            Console.ReadKey();
        }
    }
}
