using System;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
           
           ZipFile.CreateFromDirectory(@"D:\Demo1", @"D:\Demo2\zip");

            ZipFile.ExtractToDirectory(@"D:\Demo2\zip", @"\demo3");

        }
    }
}
