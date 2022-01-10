using System;
using System.Linq;

namespace CountingDuplicates
{
    public class CountingDuplicates
    {
        public int Count(string input)
        {
            if ((input ?? "").Trim() == "") { return 0; }
            
            var str = input.ToLower();
            return str.GroupBy(x => x).Count(x => x.Count() >= 2);
        }
    }
}