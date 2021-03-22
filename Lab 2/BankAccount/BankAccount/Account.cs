using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account : Transaction
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double balance { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            balance = balance;
        }
        public Account() { }


        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Money Deposit Completed.");
            Console.WriteLine();
            Transaction t = new Transaction(this, this, amount, "Self Deposit");
            this.addtransaction(t);
        }

        public void Withdraw(int amount)
        {
            if (balance > amount)
            {
                balance = balance - amount;
                Console.WriteLine("Money Withdraw Completed.");
                Transaction t = new Transaction(this, this, amount, "Self Withdraw");
                this.addtransaction(t);
            }
            else
                Console.WriteLine("Invalid Amount.");
        }
        public void Transfer(int amount, Account acc)
        {
            if (balance > amount)
            {
                balance = balance - amount;
                acc.balance = acc.balance + amount;
                Console.WriteLine("Balance Transfered.");
                Transaction t = new Transaction(this, acc, amount, "Money Transfer");
                this.addtransaction(t);
                acc.addtransaction(t);
            }
            else
                Console.WriteLine("Invalid Amount.");
        }

        public int TotalNumberOfTransaction { get; set; }

        private Transaction[] listOfTransaction;

        public void addtransaction(Transaction transaction)
        {
            listOfTransaction[TotalNumberOfTransaction++] = transaction;


        }
        public void showAllTransactions()
        {
            for (int i = 0; i < (TotalNumberOfTransaction + 1); i++)
            {
                listOfTransaction[i].showInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + balance);

        }


    }
}
