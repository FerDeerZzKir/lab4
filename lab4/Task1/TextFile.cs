using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Task1
{
    class TextFile : File
    {
        public string Content
        {
            get
            {
                return System.IO.File.Exists(FullPath)
                    ? System.IO.File.ReadAllText(FullPath)
                    : "";
            }
        }

        public void Append(string text)
        {
            Console.WriteLine("TextFile.Append() викликано");
            System.IO.File.AppendAllText(FullPath, text);
        }

        public void Print()
        {
            Console.WriteLine("TextFile.Print() викликано");
            Console.WriteLine(Content);
        }

        public override string ToString()
        {
            Console.WriteLine("TextFile.ToString() викликано");
            return $"TextFile: {Name}, Content: {Content}";
        }
    }
}