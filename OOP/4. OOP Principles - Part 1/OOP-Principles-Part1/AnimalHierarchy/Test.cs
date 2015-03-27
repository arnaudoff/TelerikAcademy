/*
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 * All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
 * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
 */

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            Kitten penka = new Kitten("Penka", 1);
            Tomcat gosho = new Tomcat("Gosho", 5);
            Frog stamat = new Frog("Stamat", 1, AnimalGender.Male);
            Dog sharo = new Dog("Sharo", 15, AnimalGender.Male);
            Cat pisana = new Cat("Pisana", 3, AnimalGender.Female);

            List<Animal> animals = new List<Animal>() { penka, gosho, stamat, sharo, pisana };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            Console.WriteLine(Animal.CalculateAverageAge(animals));
        }
    }
}
