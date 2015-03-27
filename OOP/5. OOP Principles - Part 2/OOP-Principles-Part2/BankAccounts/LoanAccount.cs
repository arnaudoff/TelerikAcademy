namespace BankAccounts
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(CustomerType customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == CustomerType.Individual)
            {
                months = Math.Max(0, months - 3);
            }
            else
            {
                months = Math.Max(0, months - 2);
            }

            return months * ((this.InterestRate / 100.0m) * this.Balance);
        }

        public override string ToString()
        {
            return string.Format("Loan account ({0}) -> Balance: {1:C}", this.Customer, this.Balance);
        }
    }
}
