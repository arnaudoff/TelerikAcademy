namespace PersonGenerator
{
    using System;

    public class PersonGenerator
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person(666);
            Person secondPerson = new Person(1337);

            Console.WriteLine("Name: {0} Age: {1} Gender: {2}", firstPerson.Name, firstPerson.Age, firstPerson.Gender);
            Console.WriteLine("Name: {0} Age: {1} Gender: {2}", secondPerson.Name, secondPerson.Age, secondPerson.Gender);
        }
    }
}
