namespace DisplayAllExecutables
{
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // This might take some time, but it does work. Just be patient.
            var startingPath = new DirectoryInfo(@"C:\Windows");
            Traverse(startingPath);
        }

        private static void Traverse(DirectoryInfo directory)
        {
            // Get current directory executables
            try
            {
                var executables = directory.GetFiles().Where(f => f.Extension == ".exe");
                foreach (var exe in executables)
                {
                    Console.WriteLine(exe.Name);
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(string.Format("Traverse failed: {0}", e.Message));
            }

            // Traverse the directories in the current directory
            foreach (var dir in directory.GetDirectories())
            {
                Traverse(dir);
            }
        }
    }
}
