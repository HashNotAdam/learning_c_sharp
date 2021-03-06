using System;
using System.Collections.Generic;

namespace introduction_to_classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }

        private List<Transaction> allTransactions = new List<Transaction>();
        private int transactionColumnLength = 20;


        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public string AccountHistory()
        {
            return AccountHistoryHeaders() +
                "\n" +
                AccountHistoryTransactions();
        }

        private string AccountHistoryHeaders()
        {
            return "Date".PadRight(transactionColumnLength) +
                "Amount".PadRight(transactionColumnLength) +
                "Note".PadRight(transactionColumnLength);
        }

        private string AccountHistoryTransactions()
        {
            var report = new System.Text.StringBuilder();
            foreach (var transaction in allTransactions)
            {
                report.AppendLine(
                    transaction.ToString(transactionColumnLength)
                );
            }
            return report.ToString();
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(amount),
                    "Amount of deposit must be positive"
                );
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(amount),
                    "Amount of withdrawal must be positive"
                );
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException(
                    "Insufficient funds for this withdrawal"
                );
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
