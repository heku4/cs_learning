//http://acm.sgu.ru/lang/problem.php?contest=2&problem=2006

using System;

namespace cs_learning
{
    class Baden
    {
        static void ConvertToBaden()
        {
            int metricLength = int.Parse(Console.ReadLine());
            
            int footLength = metricLength / 36;
            int inchLength = metricLength % 36 / 3;
            if (metricLength % 36 % 3 == 2)
            {
                Console.Write("{0} {1}", footLength, inchLength + 1);
            }
            else
            {
                Console.Write("{0} {1}", footLength, inchLength);
            }
        }
    }
}