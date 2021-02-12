using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
   public  class MyTuple<T1,T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }

        public MyTuple(T1 first,T2 second)
        {
            this.Item1 = first;
            this.Item2 = second;
        }
        public override string ToString()
        {
           
            return this.Item1 + " -> " + this.Item2;
        }
    }
}
