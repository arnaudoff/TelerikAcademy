namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, AnimalGender gender) : base(name, age, gender)
        {
            this.Type = AnimalType.Cat;
        }

        public override string MakeSound()
        {
            return "Meow meow!";
        }
    }
}