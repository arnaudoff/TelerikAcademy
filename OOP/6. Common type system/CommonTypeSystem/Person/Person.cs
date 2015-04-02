namespace Person
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public int? Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1}", this.Name, this.Age == null ? "NULL" : this.Age.ToString());
        }
    }
}