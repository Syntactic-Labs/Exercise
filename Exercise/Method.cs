using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Method
    {
        public static void HighLow()
        {
            List<int> num = new List<int>();
            num.Add(15);
            num.Add(22);
            num.Add(46);
            var max = num.Max();
            var min = num.Min();
            Console.WriteLine($"The max number is {max}");
            Console.WriteLine($"The min number is {min}");
        }
        public static void CutFirst2(string a)
        {
           var b = a.Substring(0, 2);
            Console.WriteLine(b);
        }
    }
}
