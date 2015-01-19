/*
 * A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        /* 
         * For the purpose of proper centering, this should get the console width, divide it by two and and shift the text right 
         * by the result - 7 ("Company details" has 15 chars / 2 = 7) but I won't do it because beginners might struggle to understand it.
         */
        Console.WriteLine("{0, 50}", "Company details");
        Console.WriteLine();
        Console.WriteLine("Enter name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.WriteLine("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Enter URL: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("{0, 50}", "Manager details");
        Console.WriteLine("Enter first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        // Output

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", String.IsNullOrEmpty(faxNumber) ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}
