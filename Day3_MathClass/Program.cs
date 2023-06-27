using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 25.455;
            int a = 20;
            Console.WriteLine(Math.Round(d));
            Console.WriteLine(Math.Floor(d));
            Console.WriteLine(Math.Ceiling(d));
            Console.WriteLine(Math.Truncate(d));
            Console.WriteLine(Math.Sqrt(d));
            Console.WriteLine(Math.Min(d,a));
            Console.WriteLine(Math.Max(a,d));
            Console.WriteLine(Math.Abs(d-a));   //we also use sin,cos,tan,cot,log etc
            Console.ReadLine();
        }
    }
}
