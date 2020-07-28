// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2021

using System;
using System.Linq;

namespace cs_learning
{
    class DivideMax
    {
        public void DivideMaxDoubleTimes()
        {
            int amount = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();

            for (int k = 0; k < 2;)
            {
                int maxValue = nums.Max();
                for (int i = 0; i < amount; i++)
                {
                    if (nums[i] == maxValue) nums[i] = nums[i] / 2;
                }
                k++;
            }
            foreach (int element in nums)
            {
                Console.Write("{0} ", element);
            }

        }
    }
}