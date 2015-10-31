namespace LinkedList
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            ListItem<int> head = new ListItem<int>(1337);
            list.FirstElement = head;

            ListItem<int> secondElement = new ListItem<int>(666);
            head.NextItem = secondElement;

            secondElement.NextItem = new ListItem<int>(42);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
