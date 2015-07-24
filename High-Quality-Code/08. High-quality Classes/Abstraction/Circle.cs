namespace Abstraction
{
    using System;
    using System.Text;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius) 
            : base()
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set 
            {
                Validate.Figure.IfPropertyIsLessThanZero(value, "Circle", "radius");

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine(string.Format("Radius: {0}", this.Radius));

            return result.ToString();
        }
    }
}
