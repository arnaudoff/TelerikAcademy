namespace FileSystemTree
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Folder
    {
        public Folder(string name, string fullPath)
        {
            this.Name = name;
            this.DirectoryInfo = new DirectoryInfo(fullPath);
            this.Files = new List<File>();
            this.Folders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> Folders { get; set; }

        public DirectoryInfo DirectoryInfo { get; set; }

        public decimal? Size()
        {
            return this.Files.Sum(f => f.Size) + this.Folders.Sum(f => f.Size());
        }
    }
}
