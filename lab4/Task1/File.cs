using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Task1
{
    public class File
    {
        public string Name { get; set; }
        public string DirectoryPath { get; set; } = ".";
        public string FullPath
        {
            get { return Path.Combine(DirectoryPath, Name); }
        }

        public virtual void Create()
        {
            Console.WriteLine("File.Create() викликано");
            Console.WriteLine("FullPath: " + FullPath);
            System.IO.File.WriteAllText(FullPath, "");
        }

        public virtual void Rename(string newName)
        {
            Console.WriteLine("File.Rename() викликано");

            string newPath = Path.Combine(DirectoryPath, newName);
            System.IO.File.Move(FullPath, newPath);

            Name = newName;
        }

        public virtual void Delete()
        {
            Console.WriteLine("File.Delete() викликано");
            System.IO.File.Delete(FullPath);
        }

        public override string ToString()
        {
            Console.WriteLine("File.ToString() викликано");
            return $"File: {Name}";
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("File.Equals() викликано");

            if (obj == null)
                return false;

            File f = obj as File;

            if (f == null)
                return false;

            return this.Name == f.Name;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("File.GetHashCode() викликано");
            return Name.GetHashCode();
        }
    }
}
