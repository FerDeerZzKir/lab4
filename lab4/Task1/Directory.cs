using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4.Task1
{
    class Directory
    {
        public string Name { get; set; }
        public string PathDir
        {
            get { return Name; }
        }
        public List<File> Files { get; set; } = new List<File>();

        public void Create()
        {
            Console.WriteLine("Directory.Create() викликано");
            System.IO.Directory.CreateDirectory(PathDir);
        }

        public void AddFile(File file)
        {
            Console.WriteLine("Directory.AddFile() викликано");

            file.DirectoryPath = PathDir;
            Files.Add(file);
        }

        public void RemoveFile(File file)
        {
            Console.WriteLine("Directory.RemoveFile() викликано");
            Files.Remove(file);
        }

        public override string ToString()
        {
            Console.WriteLine("Directory.ToString() викликано");
            return $"Directory: {Name}, Files count: {Files.Count}";
        }
    }
}