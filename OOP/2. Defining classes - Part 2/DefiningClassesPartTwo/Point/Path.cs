using System;

namespace Point
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this.points[index];
            }
            set
            {
                this.points[index] = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.AppendLine(string.Format("{{{0}, {1}, {2}}}", this[i].X, this[i].Y, this[i].Z));
            }

            return sb.ToString();
        }
    }
}
