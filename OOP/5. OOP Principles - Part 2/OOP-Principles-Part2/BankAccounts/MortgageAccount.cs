namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(CustomerType customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == CustomerType.Company)
            {
                if (months <= 12)
                {
                    return months * (this.Balance * 0.5m);
                }
                else
                {
                    return (12 * (this.Balance * 0.5m)) + ((months - 12) * ((this.InterestRate / 100) * this.Balance));
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0.0m;
                }
                else
                {
                    return (months - 6) * ((this.InterestRate / 100.0m) * this.Balance);
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Mortgage account ({0}) -> Balance: {1:C}", this.Customer, this.Balance);
        }
    }
}
