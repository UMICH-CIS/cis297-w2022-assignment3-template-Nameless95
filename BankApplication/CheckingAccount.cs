using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// 
    /// </summary>
    class CheckingAccount : Account
    {

        decimal fee;
        //inherit from account 
        // include a decimal instance varialble  reperresent fee charged per transsaiton 

        // constructors receive iniit balance as well as a parameter indicating fee amoun t
        // redefinie methods credit and debit so that sub the fee from the account balance
        //wenever either transaction is performed successfull
        /// <summary>
        /// constructs class needs a fee and balance balance is checked to make sure it is positve
        /// </summary>
        /// <param name="initfee"></param>
        /// <param name="initbalance"></param>
        public CheckingAccount(decimal initfee, decimal initbalance) : base(initbalance) {
            fee = initfee;
        }

        /// <summary>
        /// credit is over written to allow fee to be charged to account balance when transaction is conducted
        /// </summary>
        /// <param name="balance"></param>
        public override void credit(decimal balance) {
            if (Balance + balance >= fee)
            {
                base.credit(balance);
                base.debit(fee);
                return;
            }
            Console.WriteLine("error fee is greater than amount in bank account plus amount being added transation not performed");
        }


        /// <summary>
        /// debit method is over written to allow debit to charge a fee when transation conducted
        /// </summary>
        /// <param name="balance"></param>
        public override void debit(decimal balance)
        {
            if (Balance >= balance + fee)
            {
                base.debit(balance);
                base.debit(fee);
                return;
            }
            Console.WriteLine("error balance and fee are greater than amount in bank account transation not performed");
        }


    }
}
