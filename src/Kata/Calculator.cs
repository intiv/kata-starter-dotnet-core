using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var strings = GetDelimiters(s);
            VerifyNegatives(strings);
            return strings.Sum();
        }

        static void VerifyNegatives(IEnumerable<int> strings)
        {
            var negatives = strings.Where(x => x < 0);
            if (negatives.Any())
            {
                throw new Exception($@"Negatives not allowed: {string.Join(", ", negatives)}");
            }
        }

        static IEnumerable<int> GetDelimiters(string s)
        {
            var separator = new[] {",", "\n"};
            if (s.StartsWith("//"))
            {
                var split = s.Split("\n");
                separator = split.First().Replace("//", "").Replace("[", "").Split("]");
                s = split.Last();
            }

            var strings = s.Split(separator, StringSplitOptions.None).Select(int.Parse).Where(x => x < 1001);
            return strings;
        }
    }
}