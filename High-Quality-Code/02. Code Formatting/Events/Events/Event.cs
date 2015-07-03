namespace Events
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Event : IComparable
    {
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; private set; }

        public string Title { get; private set; }

        public string Location { get; private set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int eventByDate = this.Date.CompareTo(other.Date);
            int eventByTitle = this.Title.CompareTo(other.Title);
            int eventByLocation = this.Location.CompareTo(other.Location);

            if (eventByDate == 0)
            {
                if (eventByTitle == 0)
                {
                    return eventByLocation;
                }
                else
                {
                    return eventByTitle;
                }
            }
            else
            {
                return eventByDate;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}