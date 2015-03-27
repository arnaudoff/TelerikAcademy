namespace BankAccounts
{
    using System;

    public abstract class Account : IDepositable
    {
        public Account(CustomerType customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public CustomerType Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid amount specified.");
            }

            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return (decimal)months * this.InterestRate;
        }
    }
}