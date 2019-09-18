using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            var separator = new []{",","\n"};
            if (s.StartsWith("//"))
            {
                var strings = s.Split("\n");
                // "//;" 
                separator = new[] {strings.First().Replace("//", "")};
                s = strings.Last();
            }

            
            var numbers = s.Split(separator, StringSplitOptions.None).Select(int.Parse);
            return numbers.Sum();
        }
    }
}