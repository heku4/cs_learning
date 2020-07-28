// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2010

using System;
using System.Linq;
using System.Collections.Generic;

namespace cs_learning
{
    class SimpleEuclid
    {
        static int CountMax(int num)
        {
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void FindBCD()
        {
            int counterStack = 0;
            var numsBetween = new List<int>();

            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                if (CountMax(i) > counterStack)
                {
                    counterStack = CountMax(i);
                    numsBetween.Clear();
                    numsBetween.Add(i);
                }
                else if (CountMax(i) == counterStack)
                {
                    numsBetween.Add(i);
                }
                
            }

            Console.Write("{0}\n", numsBetween.Count);
            for (int i = 0; i <= numsBetween.Count - 1; i++)
            {
                
                if (i == (numsBetween.Count - 1))
                {
                    Console.Write("{0}", numsBetween[i]);
                } else Console.Write("{0},", numsBetween[i]);
            }
        }
    }
}
