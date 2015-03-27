namespace SchoolClasses
{
    public abstract class People
    {
        protected People() { }

        protected People(string fullname, byte age, string gender)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Gender = gender;
        }

        protected string Fullname { get; set; }

        protected byte Age { get; set; }

        protected string Gender { get; set; }
    }
}
