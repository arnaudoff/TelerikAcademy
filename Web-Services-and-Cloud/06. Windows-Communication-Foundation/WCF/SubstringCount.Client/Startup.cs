namespace SubstringCount.Client
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var client = new SubstringCountServiceClient();

            int result = client.GetOccurencesCount("foo", "foobarfoobazfoobarbazfoo");

            Console.WriteLine(result);

            client.Close();
        }
    }
}