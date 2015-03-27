namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, AnimalGender gender) : base(name, age, gender)
        {
            this.Type = AnimalType.Frog;
        }

        public override string MakeSound()
        {
            return "Rebbet, rebbet, rebbet!";
        }
    }
}