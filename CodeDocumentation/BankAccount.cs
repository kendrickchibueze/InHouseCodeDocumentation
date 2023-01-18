using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{

    [Document("This class represents a bank account", Input = "string accountNumber, double balance", Output = "none")]
    class BankAccount:IDeposit,IWithdraw
    {
        private string _accountNumber;
        private double _balance;

        [Document("This constructor initializes a new bank account", Input = "string accountNumber, double balance", Output = "none")]
        public BankAccount(string accountNumber, double balance)
        {
            _accountNumber = accountNumber;
            _balance = balance;
        }

        [Document("This method deposits a specified amount of money into the account", Input = "double amount", Output = "none")]
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        [Document("This method withdraws a specified amount of money from the account", Input = "double amount", Output = "bool indicating success or failure of the withdrawal")]
        public bool Withdraw(double amount)
        {
            if (_balance < amount)
            {
                return false;
            }
            _balance -= amount;
            return true;
        }

        [Document("This method gets the current balance of the account", Input = "none", Output = "double representing the current balance")]
        public double GetBalance()
        {
            return _balance;
        }
    }

    [Document("These are the types of account available in our crypto bank")]
    public enum AccountTypes
    {
        Savings,
        Current,
        Domicillary


    }
}
