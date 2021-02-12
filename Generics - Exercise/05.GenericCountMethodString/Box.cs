using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
        where T: IComparable
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
