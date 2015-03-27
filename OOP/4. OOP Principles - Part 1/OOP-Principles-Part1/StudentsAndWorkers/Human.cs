namespace StudentsAndWorkers
{
    public abstract class Human
    {
        protected Human() { }
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
