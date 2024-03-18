using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClhBankApp
{
    public class Customer : Person
    {
        public Customer() {
            Random random = new Random();
            CustomerNo = random.Next(1000000, 9999990);
        }
        public int CustomerNo { get; init; }
        public List<Account> Accounts { get; set; } = new List<Account>();

        public Account OpenAccount(int accountType)
        {
            Account account = null;
            if (accountType == 0)
            {
                account = new SavingsAccount();
                Accounts.Add(account);
            }
            else if (accountType == 1)
            {
                account = new CurrentAccount();
                Accounts.Add(account);
            }
            else
            {
                throw new Exception("The account type is invalid");
            }
            return account;
        }
        public int Deposit(int accountNo, double amount)
        {
            Account account = null;
            foreach (var acc in Accounts)
            {
                if (acc.AccountNo == accountNo)
                {
                    account = acc;
                    break;
                }
            }
            if (account == null)
            {
                throw new Exception("Invalid Account No");
            }
            var transactionNo = account.Credit(amount);
            return transactionNo;
        }

        public int WitdrawMoney(int accountNo, double amount)
        {
            Account account = null;
            foreach (var acc in Accounts)
            {
                if (acc.AccountNo == accountNo)
                {
                    account = acc;
                    break;
                }
            }

            if (account == null)
            {
                throw new Exception("Invalid account Number");
            }

            var transactionNo = account.Debit(amount);
            return transactionNo;

        }

        public double GetMyBalance()
        {
            var balance = 0D;
            foreach (var account in Accounts)
            {
                balance += account.GetBalance();
            }

            return balance; 
        }

        public Account CustomerOpenAccount(string firstName, string lastName, string address, string email, string password)
        {
            foreach(var acc in Accounts)
            {
                if(acc.accountNo == accountNo)
                {
                    Console.WriteLine("account already exist");
                    return null;
                }
            }
                Customer account = new Customer(firstName, lastName, address, email, password) ;
                Accounts.Add(account);
                Console.WriteLine("login successfull");
            
        }
    }
}

