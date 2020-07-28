// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2020

using System;
using System.Linq;

namespace cs_learning
{
    class MostCommonValue
    {
        public void FindValue()
        {
            Console.ReadLine();
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int currentCounter = 1;
            int currentNum = 0;
            int mostCommonValue = 0;
            int mostCommonNumber = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    currentCounter++;
                    currentNum = nums[i];
                }
                else
                {
                    if (mostCommonValue < currentCounter)
                    {
                        mostCommonValue = currentCounter;
                        mostCommonNumber = nums[i];
                        currentCounter = 1;
                    }
                    else if (mostCommonValue == currentCounter)
                    {
                        currentCounter = 1;
                    }
                }

            }
            Console.Write("{0} {1}", mostCommonNumber, mostCommonValue);
        }
    }
}
