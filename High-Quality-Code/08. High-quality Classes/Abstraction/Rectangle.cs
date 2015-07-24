namespace Abstraction
{
    using System.Text;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                Validate.Figure.IfPropertyIsLessThanZero(value, "Rectangle", "width");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                Validate.Figure.IfPropertyIsLessThanZero(value, "Rectangle", "height");
                
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine(string.Format("Width: {0}", this.Width));
            result.AppendLine(string.Format("Height: {0}", this.Height));

            return result.ToString();
        }
    }
}
