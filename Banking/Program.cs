using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount() { AccountNumber = 1122, CustomerName = "Ali", Balance = 2000 };
            BankAccount account2 = new BankAccount() { AccountNumber = 4444, CustomerName = "Ahmed", Balance = 5000 };
            EnterpriseBankAcc ITI = new EnterpriseBankAcc() { AccountNumber = 101, Balance = 2000, CustomerName = "ITI" };
            CreditAcc cAcc = new CreditAcc() { AccountNumber = 11, Balance = 2000, CustomerName = "mo", Limit = 7000 };

            List<BankAccount> banks = new List<BankAccount>() { account1, account2 };

            CustomeAgent agent = new CustomeAgent(banks) { Name = "Heba" };

            #region Subscription

            account1.OverBalance += BlackList.AddToBlackList;
            account2.OverBalance += BlackList.AddToBlackList;
            ITI.OverBalance += BlackList.AddToBlackList;
            ITI.OverBalance += agent.CallUser;
            cAcc.OverBalance += agent.CallUser;
            cAcc.OverBalance += BlackList.AddToBlackList;
            #endregion

            account1.Depit(100);
            ITI.Transfer(2000, account1);
            account1.Depit(3100);
            Console.WriteLine( BlackList.getBlackListItems());

        }
    }
}
