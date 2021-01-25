using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> information = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directory = new DirectoryInfo("../../../");

            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                if (!information.ContainsKey(files[i].Extension))
                {
                    information.Add(files[i].Extension, new Dictionary<string, double>());
                }
                information[files[i].Extension].Add(files[i].Name, files[i].Length/1000.00);
            }
            
            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\example.txt"))
            {
                foreach (var item in information.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var item2 in item.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{item2.Key} - {item2.Value}kb");
                    }
                }
            }
           

        }
    }
}
