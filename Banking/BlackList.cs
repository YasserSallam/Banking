using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    static class BlackList          //subscriber
    {        
        static List<string> BlakListAccounts = new List<string>();
        public static int Size{ get => BlakListAccounts?.Count ?? 0; }
     
        #region Call Back method
        //define call back method
        // object so that this subscriber subscrib to differnt events from differnts class
        public static void AddToBlackList(object obj, BankEventArgs e)
        {
            if (obj is BankAccount bnkacc)
            {
                if ((BlakListAccounts?.Contains(bnkacc.CustomerName) == false) && e.Diff> 1000)
                    BlakListAccounts.Add(bnkacc.CustomerName);
            }
        }

        #endregion
        //remove from blak list when new balance add
        public static void removefromlist(string accname) {
            BlakListAccounts.Remove(accname);
        }

        public static string getBlackListItems() {
            StringBuilder blackItems = new StringBuilder();
            foreach (var item in BlakListAccounts)
            {
                blackItems.Append(item).Append(" - ");
            }
            return blackItems.ToString();
        }
    }
}
