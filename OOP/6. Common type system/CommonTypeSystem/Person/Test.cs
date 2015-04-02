/*
 * Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
 * Write a program to test this functionality.
 */

namespace Person
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person gosho = new Person("Gosho");
            Person pesho = new Person("Pesho", 30);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
