// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2015

using System;
using System.Linq;

namespace cs_learning
{
    class Equation
    {
        public void NumberOfEquationRoots()
        {
            int[] abc = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            if (abc[0] != 0)
            {
                int d = abc[1] * abc[1] - 4 * abc[0] * abc[2];
                if (d == 0) Console.WriteLine("1");
                if (d > 0) Console.WriteLine("2");
                if (d < 0) Console.WriteLine("0");
            }
            else if (abc[0] == 0 && abc[1] != 0) Console.WriteLine("1");
            else if (abc[0] == 0 && abc[1] == 0 && abc[2] == 0) Console.WriteLine("-1");

        }
    }
}