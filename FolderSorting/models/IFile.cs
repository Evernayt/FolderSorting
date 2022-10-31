using System;
using System.Collections.Generic;
using System.IO;

namespace FolderSorting.models
{
    public class IFile
    {
        public string FilePath { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        private List<IFile> files = new List<IFile>();

        public List<IFile> getFiles(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                IFile newFile = new IFile
                {
                    FilePath = file,
                    Name = Path.GetFileName(file),
                    Date = File.GetLastWriteTime(file)
                };

                files.Add(newFile);
            }

            return files;
        }
    }
}
