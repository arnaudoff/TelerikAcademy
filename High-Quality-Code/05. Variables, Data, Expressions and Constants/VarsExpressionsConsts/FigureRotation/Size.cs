namespace FigureRotation
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public Size Rotate(double angle)
        {
            double rotatedWidth = CalculateNewDimensions(angle, this.Width, this.Height);
            double rotatedHeight = CalculateNewDimensions(angle, this.Height, this.Width);

            Size rotatedSize = new Size(rotatedWidth, rotatedHeight);

            return rotatedSize;
        }

        private static double CalculateNewDimensions(double angle, double width, double height)
        {
            double newWidth = Math.Abs(Math.Cos(angle)) * width;
            double newHeight = Math.Abs(Math.Sin(angle)) * height;

            return newWidth + newHeight;
        }
    }
}