using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void change(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1 - {a}, 2 - {b}");
            change(ref a, ref b);
            Console.WriteLine($"After Change: 1 - {a}, 2 - {b}");

        }
    }
}
