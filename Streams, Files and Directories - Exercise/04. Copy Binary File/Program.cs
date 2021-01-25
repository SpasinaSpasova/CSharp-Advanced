using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {

                using (FileStream writer = new FileStream("../../../newPic.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = reader.Read(buffer, 0, buffer.Length))>0)
                    {
                       
                        writer.Write(buffer, 0, bytesRead);
                    }

                }
            }

        }
    }
}

