namespace InheritanceAndPolymorphism
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validate.Person.IfPropertyIsNullOrWhitespace(value, "first name");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validate.Person.IfPropertyIsNullOrWhitespace(value, "last name");

                this.lastName = value;
            }
        }

        public int Age 
        {
            get
            {
                return this.age;
            }

            private set
            {
                Validate.Person.IfAgeIsValid(value);

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
