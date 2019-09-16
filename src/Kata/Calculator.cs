using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var strings = s.Split(",");
            if (strings.Length == 1)
                return Int32.Parse(strings[0]);
            return Int32.Parse(strings[0])+Int32.Parse(strings[1]);
        }
    }
}