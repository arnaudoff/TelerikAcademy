namespace MobilePhone
{
    using System;
    using System.Linq;

    class MobilePhone
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 79));
            Console.WriteLine("GSM tests: ");
            Console.WriteLine(new string('-', 79));
            GSM[] phones = GSMTest.GeneratePhones();
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i].ToString());
            }

            Console.WriteLine(new string('-', 79));
            Console.WriteLine("Call history tests: ");
            Console.WriteLine(new string('-', 79));
            Console.WriteLine("Phone: {0} \n", phones[1].Model);

            GSMCallHistoryTest.GenerateCallHistory(phones[1]);

            Console.WriteLine("Initial call history: \n");

            GSMCallHistoryTest.PrintHistory(phones[1]);

            Console.WriteLine();
            Console.WriteLine("Total call prices: {0}", phones[1].CalculateTotalCallsPrices(0.37f));

            // Remove the longest duration
            int max = phones[1].CallHistory.Max(x => x.Duration);
            phones[1].CallHistory = phones[1].CallHistory.Where(x => x.Duration != max).ToList();

            Console.WriteLine();
            Console.WriteLine("New call history: \n");

            // Print after removal
            GSMCallHistoryTest.PrintHistory(phones[1]);

            Console.WriteLine();
            Console.WriteLine("Total call prices (after longest call removal): {0}", phones[1].CalculateTotalCallsPrices(0.37f));

            phones[1].ClearCallHistory();

            // Print after erasing
            Console.WriteLine();
            Console.WriteLine("Call history after clearing: ");
            GSMCallHistoryTest.PrintHistory(phones[1]);
        }
    }
}
