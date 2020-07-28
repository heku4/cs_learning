// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2017

using System;
using System.Linq;
using System.Collections.Generic;

namespace cs_learning
{
    class MostDivisor
    {
        int CountMax(int num)
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
        public void CalculateMostDivisors()
        {
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int leftNum = nums[0];
            int rightNum = nums[1];
            int counterStack = 0;
            var numsBetween = new List<int>();


            for (int i = leftNum; i <= rightNum; i++)
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
                }
                else Console.Write("{0},", numsBetween[i]);
            }
        }
    }
}