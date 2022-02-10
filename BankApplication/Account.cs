using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// account is base class and controls balance through use of credit and debit methods
    /// </summary>
    class Account
    {
        // one private instance variable accesor property that returns balance
        private decimal balance;

        public decimal Balance
        {

            set {
                if (value >= 0.0M) balance = value;
                else throw new ArithmeticException();
            }
            get {
                return balance;
            }
        
        }

        /// <summary>
        /// add incoming decimal to balance
        /// </summary>
        /// <param name="bal"> decimal</param>
        // add an ammount to current balalnlce
        public virtual void  credit(decimal bal) {

            Balance += bal;
        
        }

        /// <summary>
        /// takes a decimcal and subtracts it from balance however insure balance can't go negative throw check
        /// </summary>
        /// <param name="bal"> decimal </param>
        // subtracts amount however checks to make sure debit doesn't exceed balance if does throw error 
       public virtual void debit(decimal bal) {

            if (bal > balance)
                Console.WriteLine("Debit amount exceeded account balance");
            else
                Balance -= bal;
        
        }


        /// <summary>
        /// constructs class however incoming decimal must be greater than or equal to zero else error is thrown
        /// </summary>
        /// <param name="initbala"> decimal that is set to balance of account</param>
      public  Account(decimal initbala)
        {
            try
            {
                Balance = initbala;
            }
            catch (ArithmeticException) {
                Console.WriteLine("account can't be made less than zero");
            }
        }

        //Account should provie a constructor that receives an init balance and uses it to init the instance variable pulibc pro
        // should validate init balance and throw expection if not greater than or = 0.0 ;

    }
}
