namespace Point
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void Save(Path path, string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("The name of the file cannot be empty.");
            }

            using (var file = new StreamWriter(fileName))
            {
                file.Write(path.ToString());
            }
        }

        public static Path Load(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("The name of the file cannot be empty.");
            }

            string line = string.Empty;
            Path pointsPath = new Path();
            using (var file = new StreamReader(fileName))
            {
                while ((line = file.ReadLine()) != null)
                {
                    double[] coords = line.Split(new char[] { '{', ',', ' ', '}' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(x => double.Parse(x))
                                          .ToArray();

                    pointsPath.AddPoint(new Point3D(coords[0], coords[1], coords[2]));
                }
            }

            return pointsPath;
        }
    }
}
