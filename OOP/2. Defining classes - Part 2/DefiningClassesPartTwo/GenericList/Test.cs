namespace GenericList
{
    using System;

    public class Test
    {
        static void Main()
        {
            var someList = new GenericList<int>();
            // Notice the capacity value here (the list resizes twice)
            for (int i = 1; i < 19; i++)
            {
               Console.WriteLine("Current value: {0} Current capacity: {1} Current count: {2}", i, someList.Capacity, someList.Count);
               someList.Add(i);
            }

            Console.WriteLine(new string('-', Console.BufferWidth));
            Console.WriteLine("Result: {0}", someList.ToString());
            Console.WriteLine("List[12]: {0}", someList[12]);
            Console.WriteLine("Max(): {0}", someList.Max());
            Console.WriteLine("Min(): {0}", someList.Min());
            Console.WriteLine("IndexOf(12): {0}", someList.IndexOf(12));
            Console.WriteLine("IndexOf(1337): {0}", someList.IndexOf(1337));
            someList.InsertAt(2, 666);
            Console.WriteLine("InsertAt(2, 666) => {0}", someList.ToString());
            someList.RemoveAt(2);
            Console.WriteLine("RemoveAt(2) => {0}", someList.ToString());
            someList.Clear();
            Console.WriteLine("Clear() => {0}", someList.ToString());
        }
    }
}
