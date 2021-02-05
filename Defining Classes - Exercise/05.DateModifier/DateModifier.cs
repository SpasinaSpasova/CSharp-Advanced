using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {

        public static int GetDiff(string firstDate, string secondDate)
        {

            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);
            TimeSpan diff = first - second;
            return Math.Abs(diff.Days);
        }
    }
}
