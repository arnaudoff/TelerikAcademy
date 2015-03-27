namespace Shapes
{
    public abstract class Shape
    {
        public Shape(double size)
        {
            this.Width = size;
            this.Height = size;
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public virtual double CalculateSurface()
        {
            return 0.0;
        }
    }
}