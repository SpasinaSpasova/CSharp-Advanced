using System;
using System.IO;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Directory.GetFiles("../../../TestFolder");

            double sum = 0;

            foreach (var item in file)
            {
                FileInfo fileInfo = new FileInfo(item);
                sum += fileInfo.Length;
            }
           sum=sum/1024/1024;
            File.WriteAllText("../../../output.txt", sum.ToString());
        }
    }
}
