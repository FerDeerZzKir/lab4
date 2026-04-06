using System;

namespace lab4.Task1
{
    class Program
    {
        static void Main2()
        {
            Directory dir = new Directory { Name = "Task1/MyFolder" };
            dir.Create();

            TextFile file = new TextFile { Name = "test.txt" };
            TextFile file2 = new TextFile { Name = "test2.txt" };

            dir.AddFile(file);
            dir.AddFile(file2);

            file.Create();
            file.Append("Hello ");
            file.Append("World!");
            file.Print();

            file2.Create();
            file2.Append("Hello ");
            file2.Append("World!");
            file2.Print();


            file.Rename("new.txt");

            Console.WriteLine(file.ToString());
            Console.WriteLine(file2.ToString());
            Console.WriteLine(dir.ToString());
            // file.Delete();


        }
    }
}