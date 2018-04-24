using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecMirrorString("Recursions are awesome!"));
            Console.WriteLine();

            Console.WriteLine(GetNaturalnumbers(50));
            Console.WriteLine();

            Console.WriteLine("The sum of numbers from 1 to 5 : " + SumOf(5));
            Console.WriteLine();

            Console.WriteLine(FibonacciSeries(10));
            Console.WriteLine();

            Console.ReadLine();
        }
        static string RecMirrorString(string inp)
        {
            if (inp.Length > 0)
            {
                return RecMirrorString(inp.Substring(1)) + inp.Substring(0, 1);
            }
            return "";
        }
        static string GetNaturalnumbers(int amount)
        {
            if (amount > 1)
            {
                return GetNaturalnumbers(amount - 1) + " " + amount;
            }

            return "The natural numbers are: " + amount;
        }
        static int SumOf(int n)
        {
            if (n > 1)
            {
                return SumOf(n - 1) + n;
            }
            return n;
        }
        static string FibonacciSeries(int target, int idx1 = 1, int idx2 = 0)
        {
            if (target > 1)
            {
                return idx1 + " " + FibonacciSeries(target - 1, idx1 + idx2, idx1);
            }
            return "" + idx1;

        }
    }
}
