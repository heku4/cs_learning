// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2022

using System;
using System.Linq;

namespace cs_learning
{
    class DividedPairs
    {
        public void FindPair()
        {
            int amount = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int pairs = 0;
            for (int j = amount - 1;  j > -1; j--)
            {
                
                for (int i = 0; i < amount; i++)
                {
                    if (nums[j] % nums[i] == 0 && i != j) pairs++;
                }
                
            }
                Console.Write(pairs);
        }
    }
}