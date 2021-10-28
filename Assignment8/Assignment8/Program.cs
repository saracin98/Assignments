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
            var filtered = files.OrderBy(x=>x.CreationTime).GroupBy(x => x.CreationTime.ToString("dd-MM-yyyy"));

            foreach (var group in filtered) 
            {
                foreach (var f in group)
                {
                    var newDir = Directory.CreateDirectory(@"C:\Users\rober\Documents\Downloads\"+ f.CreationTime.ToString("dd-MM-yyyy"));
                    f.MoveTo(newDir.FullName + @"\" +f.Name);
                }
            }
        }
    }
}
