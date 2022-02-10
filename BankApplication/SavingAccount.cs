using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// saving account purpose is to have an interest rate variable saved and return it to main
    /// </summary>
    class SavingAccount : Account
    {
        
        private decimal interest;

        /// <summary>
        /// calucates interest rate and returns it 
        /// </summary>
        /// <returns> returns inerest rate times balance</returns>
       public decimal calcinterest() {

            return interest * Balance;
        }


        // constructor should receive initail balance as well value for ineterst rate 
        /// <summary>
        /// constructors for saving account needs a balance and interest rate value 
        /// </summary>
        /// <param name="initbal"></param>
        /// <param name="initinterset"></param>
       public SavingAccount(decimal initbal, decimal initinterset) 
        : base(initbal) 
        {
            interest = initinterset;
        }

        // calacualte interstest method shoudl return a decimcal value
        


    }
}
