using System;

namespace Point
{
    class Test
    {
        static void Main()
        {
            Path pointsPath = new Path();
            pointsPath.AddPoint(new Point3D(10, 10, 10));
            pointsPath.AddPoint(new Point3D(0.5, 0.3, 0.4));
            pointsPath.AddPoint(new Point3D(0.7, 0.24, 5.73));
            Console.WriteLine(pointsPath.ToString());
        }
    }
}
