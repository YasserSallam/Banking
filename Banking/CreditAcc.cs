using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class CreditAcc: BankAccount
    {
        public int Limit { get; set; }

        protected override void onOverBalance(BankEventArgs e)
        {
            if(e.Diff>Limit)
            base.onOverBalance(e);
    }

    }
}
