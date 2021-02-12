using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.GenericBoxofString
{
    public class Box<T>
    {
        public T value { get; set; }
        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            Type valueType = this.value.GetType();
            string valueNameType = valueType.FullName;
            return valueNameType + ": " + value;
        }
    }
}
