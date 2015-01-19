/*
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

using System;

class BankAccountData
{
    static void Main()
    {
        string bankName = "KTB";
        string firstName = "Tsvetan";
        string middleName = "Radoev";
        string lastName = "Vasilev";
        decimal balance = 200000000;
        string IBAN = "BG80 BNBG 9661 1020 3456 78"; // http://www.odit.info/?s=2&i=481
        long[] creditCards = new long[3]; // http://www.getcreditcardnumbers.com/
        creditCards[0] = 4916222358710668;
        creditCards[1] = 5230076233764613;
        creditCards[2] = 379908050058095;

        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.Write("Credit card numbers: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(creditCards[i] + " ");
        }
        Console.WriteLine();
    }
}
