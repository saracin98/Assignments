using System;
using System.IO;
using System.Linq;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo downolads = new DirectoryInfo(@"C:\Users\rober\Downloads");

            FileInfo[] files = downolads.GetFiles();
            DirectoryInfo[] directories = downolads.GetDirectories();
            var filteredFiles = files.OrderBy(x=>x.CreationTime).GroupBy(x => x.CreationTime.ToString("dd-MM-yyyy"));
            var filteredDirectories = directories.OrderBy(x => x.CreationTime).GroupBy(x => x.CreationTime.ToString("dd-MM-yyyy"));

            foreach (var group in filteredFiles) 
            {
                foreach (var f in group)
                {
                    var newDir = Directory.CreateDirectory(@"C:\Users\rober\Documents\Downloads\"+ group.Key);
                    f.MoveTo(newDir.FullName + @"\" +f.Name);
                }
            }

            foreach (var group in filteredDirectories)
            {
                foreach (var d in group)
                {
                    var newDir = Directory.CreateDirectory(@"C:\Users\rober\Documents\Downloads\" + group.Key);
                    d.MoveTo(newDir.FullName + @"\" + d.Name);
                }
            }
        }
    }
}
