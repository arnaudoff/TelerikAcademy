namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double diameter) : base(diameter)
        {

        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Height / 2.0) * (this.Height / 2.0);
        }
    }
}