namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, AnimalGender gender) : base(name, age, gender)
        {
            this.Type = AnimalType.Dog;
        }

        public override string MakeSound()
        {
            return "Bau bau!";
        }
    }
}