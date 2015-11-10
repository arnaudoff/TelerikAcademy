namespace BiDictionary
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            BiDictionary<string, string, int> shops = new BiDictionary<string, string, int>(false);

            shops.Add("Billa", "Sofia", 10);
            shops.Add("Metro", "Veliko Tarnovo", 2);
            shops.Add("Metro", "Burgas", 1);
            shops.Add("Metro", "Burgas", 2);
            shops.Add("Technopolis", "Sofia", 4);
            shops.Add("T-Market", "Varna", 5);

            var metrosInBulgaria = shops.FindByFirstKey("Metro"); // 2 in VT and one in Burgas
            Console.WriteLine(metrosInBulgaria.Sum());

            var shopsInSofia = shops.FindBySecondKey("Sofia"); // 10 "billas" and 4 "technopolises"
            Console.WriteLine(shopsInSofia.Sum());

            var metrosInBurgas = shops.FindByBothKeys("Metro", "Burgas");
            Console.WriteLine(metrosInBurgas.Sum());
        }
    }
}
