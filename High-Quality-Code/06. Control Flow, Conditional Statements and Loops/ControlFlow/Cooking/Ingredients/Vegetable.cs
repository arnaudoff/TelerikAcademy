namespace Cooking.Ingredients
{
    using System;
    using System.Text;

    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public bool IsRotten { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0}", this.GetType().Name));
            result.AppendLine(string.Format("Peeled: {0}", this.IsPeeled));
            result.AppendLine(string.Format("Cut: {0}", this.IsCut));
            result.AppendLine(string.Format("Rotten: {0}", this.IsRotten));

            return result.ToString();
        }
    }
}
