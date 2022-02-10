using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// This program implements a bank account as a series of polymorphic classes
    /// </summary>
    /// <Student>Jaxon Pecora</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    class Program
    {
        /// <summary>
        /// tests methods of variety of classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("testing account class");
            decimal test1 = 30M;
            Account account1 = new Account(test1);
            Console.WriteLine("{0} balance of account", account1.Balance);

            Console.WriteLine("checking add 40 using credit method");
            account1.credit(40M);
            Console.WriteLine("{0} balance of account", account1.Balance);
            Console.WriteLine("checking debit method of account 50 using debit method");
            account1.debit(50M);
            Console.WriteLine("{0} balance of account", account1.Balance);

            Account account2 = new Account(-0.4M); // works as intended 
                                                   // all account methods work 


            Console.WriteLine("\n\ntesting checking  class");
            CheckingAccount check1 = new CheckingAccount(10M, 50M);
            Console.WriteLine("checking add 40 using checking account credit method");
            check1.credit(40M);
            Console.WriteLine("{0} balance of account", check1.Balance);
            Console.WriteLine("checking debit method of account using 70");
            check1.debit(70M);
            Console.WriteLine("{0} balance of account", check1.Balance);
            Console.WriteLine("checking debit method of account using 70 should give error");
            check1.debit(70M);
            Console.WriteLine("{0} balance of account", check1.Balance);
            Console.WriteLine("checking credit method of account using 9 should give error");
            check1.debit(9M);
            Console.WriteLine("{0} balance of account", check1.Balance);

            // checking  methods work

            Console.WriteLine("\n\ntesting saving account");
            Console.WriteLine(" testing construcstor for saving account with 50m and .30m interest rate");
            SavingAccount savingacc1 = new SavingAccount(50M , .30M);
            Console.WriteLine("{0} balance of account", savingacc1.Balance);

            Console.WriteLine("testing calucalte interest method interest amount will be added by credit to account balance");
            savingacc1.credit(savingacc1.calcinterest());
            Console.WriteLine("{0} balance of account", savingacc1.Balance);
            Console.WriteLine("method testing completed going on to polymorphic testing code provide by professor\n\n\n");



                 // create array of accounts
            Account[] accounts = new Account[4];

            // initialize array with Accounts
            accounts[0] = new SavingAccount(25M, .03M);
            accounts[1] = new CheckingAccount(1M, 80M);
            accounts[2] = new SavingAccount(200M, .015M);
            accounts[3] = new CheckingAccount(.5M, 80M);

            // loop through array, prompting user for debit and credit amounts
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"Account {i + 1} balance: {accounts[i].Balance:C}");

                Console.Write($"\nEnter an amount to withdraw from Account {i + 1}: ");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

                accounts[i].debit(withdrawalAmount); // attempt to debit

                Console.Write($"\nEnter an amount to deposit into Account {i + 1}: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());

                // credit amount to Account
                accounts[i].credit(depositAmount);

                // if Account is a SavingsAccount, calculate and add interest
                if (accounts[i] is SavingAccount)
                {
                    // downcast
                    SavingAccount currentAccount = (SavingAccount)accounts[i];

                    decimal interestEarned = currentAccount.calcinterest();
                    Console.WriteLine($"Adding {interestEarned:C} interest to Account {i + 1} (a SavingsAccount)");
                    currentAccount.credit(interestEarned);
                }

                Console.WriteLine($"\nUpdated Account {i + 1} balance: {accounts[i].Balance:C}\n\n");
            }



            Console.ReadLine();


        }
    }
}
