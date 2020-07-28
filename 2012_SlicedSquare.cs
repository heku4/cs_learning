// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2012

using System;
using System.Linq;

namespace c_learning
{
    class Program
    {
        static void IsSliced()
        {
            int[] fig1 = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int[] fig2 = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            if ((fig1[0] == fig2[0] && fig1[1] + fig2[1] == fig2[0]) || (fig1[1] == fig2[0] && fig1[0] + fig2[1] == fig2[0]) || (fig1[0] == fig2[1] && fig1[1] + fig2[0] == fig2[1]) || (fig1[1] == fig2[1] && fig1[0] + fig2[0] == fig2[1]))
            {
                Console.WriteLine("YES");
            } else
            {
                Console.Write("NO");
            }
        }
    }
}