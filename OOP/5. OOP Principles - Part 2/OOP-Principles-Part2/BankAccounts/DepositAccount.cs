namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(CustomerType customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {

        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("The amount cannot be bigger than the balance.");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance >= 1000.0m)
            {
                return months * ((this.InterestRate / 100.0m) * this.Balance);
            }

            else return 0.0m;
        }

        public override string ToString()
        {
            return string.Format("Deposit account ({0}) -> Balance: {1:C}", this.Customer, this.Balance);
        }
    }
}
