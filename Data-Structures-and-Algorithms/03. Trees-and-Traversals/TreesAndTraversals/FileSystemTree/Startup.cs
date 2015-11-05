namespace FileSystemTree
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            //Folder startingDirectory = new Folder("Windows", @"C:\Windows");
            Folder startingDirectory = new Folder("Help", @"C:\Windows\Help");
            LoadDirectory(startingDirectory);

            PrintTree(startingDirectory);
        }

        public static void PrintTree(Folder tree)
        {
            List<Folder> firstStack = new List<Folder>();
            firstStack.Add(tree);

            List<List<Folder>> childListStack = new List<List<Folder>>();
            childListStack.Add(firstStack);

            while (childListStack.Count > 0)
            {
                List<Folder> childStack = childListStack[childListStack.Count - 1];

                if (childStack.Count == 0)
                {
                    childListStack.RemoveAt(childListStack.Count - 1);
                }
                else
                {
                    tree = childStack[0];
                    childStack.RemoveAt(0);

                    string indent = "";
                    for (int i = 0; i < childListStack.Count - 1; i++)
                    {
                        indent += (childListStack[i].Count > 0) ? "|  " : "   ";
                    }

                    Console.WriteLine(indent + "+- " + tree.Name);

                    if (tree.Folders.Count > 0)
                    {
                        childListStack.Add(new List<Folder>(tree.Folders));
                    }
                }
            }
        }

        private static void LoadDirectory(Folder folder)
        {
            foreach (var file in folder.DirectoryInfo.GetFiles())
            {
                // Casted to an int just to comply with the requirements
                var currentFile = new File(file.Name, (int)file.Length);
                folder.Files.Add(currentFile);
            }

            // Traverse the directories in the current directory
            foreach (var directory in folder.DirectoryInfo.GetDirectories())
            {
                var currentDirectory = new Folder(directory.Name, directory.FullName);
                folder.Folders.Add(currentDirectory);

                LoadDirectory(currentDirectory);
            }
        }
    }
}
