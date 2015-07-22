namespace Cooking
{
    using System;
    using Tools;

    public class Cooking
    {
        public static void Main()
        {
            Chef petrov = new Chef();
            Bowl result = petrov.Cook();
            Console.WriteLine(result.ToString());
        }
    }
}
