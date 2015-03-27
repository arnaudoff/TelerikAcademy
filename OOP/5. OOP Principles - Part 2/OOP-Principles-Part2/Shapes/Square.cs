namespace Shapes
{
    class Square : Rectangle
    {
        public Square(double width) : base(width)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
