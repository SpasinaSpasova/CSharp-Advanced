using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T right;
        private T left;

        public EqualityScale(T left, T right)
        {
            this.right = right;
            this.left = left;
        }
        public bool AreEqual()
        {
            
            return right.Equals(left);

        }
    }
}
