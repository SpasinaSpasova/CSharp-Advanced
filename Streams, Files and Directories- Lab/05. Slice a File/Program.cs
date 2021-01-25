using System;
using System.IO;
using System.Security.Cryptography;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                long chunkSize = (long)Math.Ceiling((double)stream.Length / (double)4);


                for (int i = 0; i < 4; i++)
                {
                byte[] buffer = new byte[4096];
                    int count = 0;
                   
                    using (FileStream writer=new FileStream($"../../../text{i+1}.txt",FileMode.Create,FileAccess.Write))
                    {
                        while (count<chunkSize)
                        {
                            stream.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }

                }
            }
        }
    }
}
