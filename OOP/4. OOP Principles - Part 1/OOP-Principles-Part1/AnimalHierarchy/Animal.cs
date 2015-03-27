namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public AnimalGender Gender { get; set; }

        public Animal(string name, int age, AnimalGender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = AnimalType.Unknown;
        }

        public virtual string MakeSound()
        {
            return "";
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Type: {1} Gender: {2} Age: {3}", this.Name, this.Type, this.Gender, this.Age);
        }

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
