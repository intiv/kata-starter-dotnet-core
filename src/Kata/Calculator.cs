using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            var strings = s.Split(",").Select(int.Parse);
            if (strings.Count() == 1)
                return strings.First();
            return strings.First() + strings.Last();
        }
    }
}