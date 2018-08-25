using System;

namespace introduction_to_classes
{
    class Program
    {
        private static BankAccount account;
        static void Main(string[] args)
        {
            DepositInitialBalance();
            TestValidTransactions();
            TestInvalidTransactions();
            WriteAccountHistory();
        }

        static void DepositInitialBalance()
        {
            account = new BankAccount("Adam Rice", 1000);
            Console.WriteLine(
                $"Account {account.Number} was created for {account.Owner} " +
                $"with {account.Balance} initial balance."
            );
        }

        static void TestValidTransactions()
        {
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);
        }

        static void TestInvalidTransactions()
        {
            TestInvalidStartingBalance();
            TestAttemptToOverdraw();
        }

        static void TestInvalidStartingBalance()
        {
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(
                    "\nException caught creating account with negative balance"
                );
                Console.WriteLine(
                    "-------------------------------------------------------"
                );
                Console.WriteLine(e.ToString());
            }
        }

        static void TestAttemptToOverdraw()
        {
            try
            {
                account.MakeWithdrawal(
                    account.Balance + 1,
                    DateTime.Now,
                    "Attempt to overdraw"
                );
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(
                    "\nException caught trying to overdraw" +
                    "\n-----------------------------------" +
                    $"\n{e.ToString()}"
                );
            }
        }

        static void WriteAccountHistory()
        {
            Console.WriteLine("\n" + account.AccountHistory());
        }
    }
}
