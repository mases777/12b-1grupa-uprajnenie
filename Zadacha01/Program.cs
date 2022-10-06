using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var r = double.Parse(Console.ReadLine());

            //var s = Math.PI * r * r;
            //var c = 2 * Math.PI * r;

            //Console.WriteLine($"{s:f2}");
            //Console.WriteLine($"{c:f2}");

            //var a = double.Parse(Console.ReadLine());
            //var b = double.Parse(Console.ReadLine());
            //var c = double.Parse(Console.ReadLine());

            //var v = a * b * c;

            //Console.WriteLine(v);

            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var k = double.Parse(Console.ReadLine());

            var B = a * b;
            var P = 2 * (a + b);
            var S = P * k / 2;
            var S1 = S + B;
            var V = B * h / 3;

            Console.WriteLine(B);
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.WriteLine(S1);
            Console.WriteLine(V);
                

        }
    }
}
