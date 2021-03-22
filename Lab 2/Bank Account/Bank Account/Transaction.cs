using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Transaction
    {
        public Account  sender { get; set; }
        public Account receiver { get; set; }
        public int amount { get; set; }
        public string additionalInfo { get; set; }

        public Transaction() { }

        public Transaction( ) 
        {

        }


    
    
    }
}
