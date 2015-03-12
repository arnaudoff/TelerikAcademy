namespace GenericList
{
    class Test
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            // It should resize two times
            for (int i = 0; i < 17; i++)
            {
                System.Console.WriteLine("Capacity: {0} Count: {1}", list.Capacity, list.Count);
                list.Add(i);
            }
        }
    }
}
