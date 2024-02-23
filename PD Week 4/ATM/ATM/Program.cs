using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

             ATM atm = new ATM(100);
            atm.DepositionOfMoney(120);
            Console.WriteLine(atm.CheckBalance());
            atm.WithdrawingOfMoney(20);

        }
    }
}
