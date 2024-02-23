using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public double ATMAmount;
        public List<string> HistoryfATM = new List<string> ();
        public ATM(double amount)
        {
            ATMAmount = amount;
        }
        public void DepositionOfMoney(float amount)
        {
           ATMAmount = ATMAmount + amount;
            string msg = "Depositing " + amount + "Total " + ATMAmount;
            ATMHistory(msg);
        }
        public void WithdrawingOfMoney(float amount)
        {
            ATMAmount = ATMAmount - amount;
            string msg = "Withdrawing" + amount + "Total " + ATMAmount;
            ATMHistory(msg);
        }
        public void ATMHistory(string msg)
        {
            HistoryfATM.Add(msg);
        }
        public double CheckBalance()
        {
            return ATMAmount;
        }

    }
}
