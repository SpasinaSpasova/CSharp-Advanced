using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueNameType = valueType.FullName;
            return valueNameType + ": " + Value;
        }
    }
}
