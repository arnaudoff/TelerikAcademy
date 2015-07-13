namespace FigureRotation
{
    using System;

    public class FigureRotation
    {
        public static void Main(string[] args)
        {
            Size initialSize = new Size(50, 50);

            Console.WriteLine("Initial width: {0}", initialSize.Width);
            Console.WriteLine("Initial height: {0}", initialSize.Height);

            Size newSize = initialSize.Rotate(90);

            // Presumably a wrong formula in the task. A rotated by 90 degrees square cannot have a different dimensions.
            Console.WriteLine("Rotated width: {0}", newSize.Width);
            Console.WriteLine("Rotated height: {0}", newSize.Height);
        }
    }
}
