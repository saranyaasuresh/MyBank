using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{

    public enum TypeOfAccounts
    {
        Checkings,
        Savings
    }
/// <summary>
/// This class describes a bank account
/// 
/// </summary>
   public class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        #endregion
        #region properties
        /// <summary>
        /// Account number of the account
        /// </summary>
        public int AccountNumber { get;
           private set; }
        /// <summary>
        /// Email Addressof the user
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Balance in users account
        /// </summary>
        public decimal Balance { get;
            private set; }
        /// <summary>
        /// Type of account user is using
        /// </summary>
        public TypeOfAccounts  AccountType { get; set; }
        #endregion

        #region Constructors
         public Account()
        {//lastAccountNumber++;
            //
            AccountNumber = ++lastAccountNumber;
        }
        #endregion
        #region methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns>The new balance</returns>
        public decimal Deposit(decimal amount)
        {
            //  Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            return Balance;
        }
        #endregion
    }
}
