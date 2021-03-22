using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public int Ammount { get; set; }
        public String AdditionalInfo { get; set; }

        public Transaction() { }
        public Transaction(Account Sender, Account Receiver, int Ammount, String AdditionalInfo)
        {
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Ammount = Ammount;
            this.AdditionalInfo = AdditionalInfo;
        }

        public void showInfo()
        {
            Console.WriteLine("Sender Name: {0} Account ID: {1}", Sender.AccName, Sender.AccNo);
            Console.WriteLine("Receiver Name:{0} Account ID:{1}", Receiver.AccName, Receiver.AccNo);
            Console.WriteLine("Ammount:" + Ammount);
            Console.WriteLine("Additional Information:" + AdditionalInfo);
            Console.WriteLine();
        }

    }
}
