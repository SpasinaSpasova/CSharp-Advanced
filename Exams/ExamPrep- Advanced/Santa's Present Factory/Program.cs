using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());


            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            int doll = 0;
            int train = 0;
            int bear = 0;
            int bycicle = 0;
            while (materials.Count > 0 && magicLevel.Count > 0)
            {
                int material = materials.Peek();
                int magic = magicLevel.Peek();

                if (material == 0)
                {
                    materials.Pop();

                }
                if (magic == 0)
                {
                    magicLevel.Dequeue();

                }
                int multiply = material * magic;

                if (multiply == 150)
                {
                    doll++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (multiply == 250)
                {
                    train++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (multiply == 300)
                {
                    bear++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (multiply == 400)
                {
                    bycicle++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (multiply < 0)
                {
                    int sum = magic + material;
                    materials.Pop();
                    magicLevel.Dequeue();
                    materials.Push(sum);
                }
                else if (multiply > 0)
                {
                    magicLevel.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }

            }
            if ((doll > 0 && train > 0) ||
              (bear > 0 && bycicle > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magicLevel.Count > 0)
            {
                Console.WriteLine($"Magic left:{string.Join(", ", magicLevel)}");
            }
            if (bear > 0)
            {
                Console.WriteLine($"Teddy bear: {bear}");

            }
            if (bycicle > 0)
            {
                Console.WriteLine($"Bicycle: {bycicle}");

            }
            if (doll > 0)
            {
                Console.WriteLine($"Doll: {doll}");

            }
            if (train > 0)
            {

                Console.WriteLine($"Wooden train: {train}");
            }
        }
    }
}
