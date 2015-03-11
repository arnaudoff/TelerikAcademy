namespace Point
{
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D startingPoint;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartingPoint
        {
            get
            {
                return StartingPoint;
            }
        }

        static Point3D()
        {
            startingPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double xCoordinate, double yCoordinate, double zCoordinate) : this()
        {
            this.X = xCoordinate;
            this.Y = yCoordinate;
            this.Z = zCoordinate;
        }

        public override string ToString()
        {
            return string.Format("{{0}, {1}, {2}}", this.X, this.Y, this.Z);
        }
    }
}
