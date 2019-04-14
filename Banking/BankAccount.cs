using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class BankAccount       //bublisher class
    {
        #region properties
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }
        #endregion
        #region system.object
        public override string ToString()
        => $"{AccountNumber} , { CustomerName} ,{Balance}";
        #endregion
        #region Class Method
        public bool Credit(decimal Amount)
        {
            if (Amount > 0)
            {
                Balance += Amount;
                return true;
            }
            return false;
        }

        public bool Depit(decimal Amount)
        {
            if (Amount > Balance)
            {
                // OverBalance.Invoke(this, new EventArgs());
                onOverBalance(new BankEventArgs() { Diff = Math.Abs(Amount - Balance) });
                return false;
            }
            else
            {
                Balance -= Amount;
                return true;
            }

        }
        #endregion
        #region Event Declartion And Method that invoke it

        //1- event declration
        // generic if u want to pass arguments
        public event EventHandler<BankEventArgs> OverBalance; 
        protected virtual void onOverBalance(BankEventArgs e)
        {
            //2- invoke event
            OverBalance?.Invoke(this, e);
        }
        #endregion
     
    }
}
