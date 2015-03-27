﻿namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public void AddAccount(Account acc)
        {
            this.accounts.Add(acc);
        }

        public void RemoveAccount(Account acc)
        {
            this.accounts.Remove(acc);
        }

        public override string ToString()
        {

            StringBuilder result = new StringBuilder();

            foreach (var account in this.accounts)
            {
                result.AppendLine(account.ToString());
            }

            return result.ToString();
        }
    }
}