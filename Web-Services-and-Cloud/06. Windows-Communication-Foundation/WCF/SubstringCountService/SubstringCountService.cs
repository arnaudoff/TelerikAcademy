namespace SubstringCountService
{
    using System.Text.RegularExpressions;

    public class SubstringCountService : ISubstringCountService
    {

        public int GetOccurencesCount(string first, string second)
        {
            return Regex.Matches(second, first).Count;
        }
    }
}
