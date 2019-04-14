using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class BankEventArgs : EventArgs
    {
        public decimal Diff { get; set; }
        public DateTime time { get => DateTime.Now; }
    }
}
