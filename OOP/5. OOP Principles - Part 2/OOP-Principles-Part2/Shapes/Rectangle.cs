namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        // When used as a square
        public Rectangle(double width) : base(width)
        {

        }
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}