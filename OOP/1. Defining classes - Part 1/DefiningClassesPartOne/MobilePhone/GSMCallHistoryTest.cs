namespace MobilePhone
{
    using System;

    public static class GSMCallHistoryTest
    {
        public static GSM GenerateCallHistory(GSM phone)
        {
            phone.AddCall(new Call(new DateTime(2015, 3, 10, 10, 21, 00), "+359888888888", 4));
            phone.AddCall(new Call(new DateTime(2015, 3, 10, 10, 25, 00), "+359888888888", 19));
            phone.AddCall(new Call(new DateTime(2015, 3, 10, 10, 45, 00), "+359133713371", 48));

            phone.AddCall(new Call(new DateTime(2015, 3, 11, 22, 35, 00), "+359555555555", 7));
            phone.AddCall(new Call(new DateTime(2015, 3, 11, 22, 48, 00), "+359666666666", 24));
            phone.AddCall(new Call(new DateTime(2015, 3, 11, 23, 15, 00), "+359888888888", 49));

            return phone;
        }

        public static void PrintHistory(GSM phone)
        {
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
