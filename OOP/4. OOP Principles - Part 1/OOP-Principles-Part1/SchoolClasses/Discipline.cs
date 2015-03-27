namespace SchoolClasses
{
    public class Discipline
    {
        public Discipline(string name, ushort numberOfLectures, ushort numberOfExercies)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercies;
        }

        public string Name { get; set; }

        public ushort NumberOfLectures { get; set; }

        public ushort NumberOfExercises { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1} lectures and {2} exercises)", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
