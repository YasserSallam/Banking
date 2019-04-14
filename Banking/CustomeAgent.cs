using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class CustomeAgent          //subscriber
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        
        //call back method
        public  void CallUser(object obj, BankEventArgs e) {
            BankAccount bnkAcc = obj as BankAccount;
            Console.WriteLine($"customer Agent {Name} calling {bnkAcc.CustomerName}  at {e.time.ToShortTimeString()}");

        }
        public CustomeAgent(List<BankAccount> banks)        //List of client assend to agent
        {
            foreach (var item in banks)
            {
                item.OverBalance += CallUser;
            }

        }
    }
}
