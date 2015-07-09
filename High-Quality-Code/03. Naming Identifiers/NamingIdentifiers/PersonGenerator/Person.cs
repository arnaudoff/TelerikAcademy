namespace PersonGenerator
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;
            if (age % 2 == 0)
            {
                this.Name = "Ivancho";
                this.Gender = GenderType.Male;
            }
            else
            {
                this.Name = "Mariika";
                this.Gender = GenderType.Female;
            }
        }

        public GenderType Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
