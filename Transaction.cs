using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClhBankApp
{
    public class Transaction
    {
        public Transaction() {
            Random random = new Random();
            TransactionNo = random.Next(1000000, 9999990);
        }
        public int TransactionNo { get; set; }
        public Account Account { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }
}
