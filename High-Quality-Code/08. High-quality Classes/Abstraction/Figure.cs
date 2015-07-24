namespace Abstraction
{
    using System.Text;

    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", this.GetType().Name));
            result.AppendLine(string.Format("Perimeter: {0}", this.CalculatePerimeter()));
            result.AppendLine(string.Format("Area: {0}", this.CalculateArea()));
            
            return result.ToString();
        }
    }
}
