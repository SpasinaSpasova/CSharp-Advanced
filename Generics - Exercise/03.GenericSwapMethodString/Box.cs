using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
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
