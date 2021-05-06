using System;
using System.Collections.Generic;
using System.IO;

namespace DependecyLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Program Files (x86)\Default Company Name\Foldio-Desktop-Setup");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            List<string> str = new List<string>();
            foreach (FileInfo file in Files)
            {
               str.Add(file.Name.ToString());
            }
            System.IO.File.WriteAllLines("c:\\Dependency.dat", str);
        }
    }
}
