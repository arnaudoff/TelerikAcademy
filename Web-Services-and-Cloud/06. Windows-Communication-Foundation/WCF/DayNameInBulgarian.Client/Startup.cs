namespace DayNameInBulgarian.Client
{
    using DayNameInBulgarian.Client.DayNameInBulgarianService;
    using System;

    public class Startup
    {
        public static void Main()
        {
            var client = new DayNameInBulgarianServiceClient();

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(client.GetDayOfWeekInBulgarian(DateTime.Now));

            client.Close();
        }
    }
}