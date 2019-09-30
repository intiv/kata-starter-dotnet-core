using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            var strings = s.Split(",");
            if (strings.Count() == 1)
                return int.Parse(strings.First());
            return int.Parse(strings.First()) + int.Parse(strings.Last());
        }
    }
}