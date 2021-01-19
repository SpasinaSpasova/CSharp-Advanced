using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneBulletPrice = int.Parse(Console.ReadLine());
            int originalSizeOfGunBarrel=int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            int barrel = originalSizeOfGunBarrel;


            Stack<int> stack = new Stack<int>(bullets);//патрони
            Queue<int> queue = new Queue<int>(locks);//ключалки

            int bulletCount = 0;


            while (stack.Count>0&&queue.Count>0)
            {
                int currBullet = stack.Pop();
                int currLock = queue.Peek();

                bulletCount++;
                barrel--;
                if (currBullet<=currLock)
                {
                    queue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (barrel==0&&stack.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    barrel = originalSizeOfGunBarrel;
                }
                


                
            }
            if (stack.Count==0&&queue.Count>0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
            else 
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligence-=oneBulletPrice*bulletCount}");
            }
        }
    }
}
