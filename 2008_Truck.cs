//http://acm.sgu.ru/lang/problem.php?contest=2&problem=2008

using System;
using System.Linq;

namespace cs_learning
{
    class Truck
    {
        public void LiftingCapacity()
        {
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int[] items = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int fullWeight = 0;
            int overAll = 0;
            for (int i = 0; i < items.Length; i ++)
            {
                if (fullWeight + items[i] <= nums[1])
                {
                    fullWeight += items[i];
                    overAll++;
                }
            }
            Console.Write("{0} {1}", overAll, fullWeight);
        }
    }
}