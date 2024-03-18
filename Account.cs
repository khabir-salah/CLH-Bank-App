using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClhBankApp
{
    public abstract class Account
    {
        /*public*/ protected Account() { 
            
            Random random = new Random();
            AccountNo = random.Next(1000000, 9999990);
        }
        public int AccountNo {  get; set; }
        private List<Transaction> TransactionList { get; set; } = new List<Transaction>();
        public double GetBalance()
        {
            var credit =0D;
            var debit = 0D;
            foreach (var transaction in TransactionList) 
            { 
                if(transaction.TransactionType == TransactionType.Credit)
                {
                    credit += transaction.Amount;
                }
                else if(transaction.TransactionType == TransactionType.Debit)
                {
                    debit += transaction.Amount;
                }
            }
            return credit - debit;
        }
        public double GetTotalCredit()
        {
            var totalCredit = 0D;
            foreach (var transaction in TransactionList)
            {
                if(transaction.TransactionType == TransactionType.Credit) { 
                    totalCredit += transaction.Amount;
                }
            }
            return totalCredit;
        }

        public double GetTotalDebit()
        {
            var totalDebit = 0D;
            foreach (var transaction in TransactionList)
            {
                if (transaction.TransactionType == TransactionType.Debit)
                {
                    totalDebit += transaction.Amount;
                }
            }
            return totalDebit;
        }

        public int Credit(double amount)
        {
            var transaction = new Transaction();
            transaction.Amount = amount;
            transaction.Account = this;
            transaction.TransactionDate = DateTime.Now;
            transaction.TransactionType = TransactionType.Credit;
            TransactionList.Add(transaction);
            return transaction.TransactionNo;
        }

        public int Debit(double amount)
        {
            if(amount > GetBalance()){
                throw new ArgumentException("Amount is greater than available balance");
            }
            var transaction = new Transaction();
            transaction.Amount = amount;
            transaction.Account = this;
            transaction.TransactionDate = DateTime.Now;
            transaction.TransactionType = TransactionType.Debit;
            TransactionList.Add(transaction);
            return transaction.TransactionNo;
        }

        public void PrintStatement()
        {
            foreach (var transaction in TransactionList)
            {
                Console.WriteLine($"{transaction.TransactionDate}   {transaction.TransactionType} {transaction.Amount}");
            }

            Console.WriteLine($"The balance of this account is {GetBalance()}");

        }



    }
}
