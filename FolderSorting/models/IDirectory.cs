using System;
using System.Collections.Generic;
using System.IO;

namespace FolderSorting.models
{
    public class IDirectory
    {
        public string DirectoryPath { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        private List<IDirectory> directories = new List<IDirectory>();

        public List<IDirectory> getDirectories(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                IDirectory newDirectory = new IDirectory
                {
                    DirectoryPath = directory,
                    Name = Path.GetFileName(directory),
                    Date = Directory.GetLastWriteTime(directory)
                };

                directories.Add(newDirectory);
            }

            return directories;
        }
    }
}
