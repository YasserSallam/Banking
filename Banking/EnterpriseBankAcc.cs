using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class EnterpriseBankAcc:BankAccount
    {
        public bool Transfer(decimal Amount, BankAccount Destination) {
            if (Amount <= Balance)
            {
                Balance -= Amount;
                Destination.Balance += Amount;
                BlackList.removefromlist(Destination.CustomerName);
                return true;
            }
            else {
                onOverBalance(new BankEventArgs() {  Diff= Amount-Balance});
                return false;
            }


        }

    }
}
