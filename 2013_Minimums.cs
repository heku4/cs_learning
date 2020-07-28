// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2013

using System;
using System.Linq;

namespace cs_learning
{
    class Minimums
    {
        public void FindQuantity()
        {
            Console.ReadLine();
            int[] nums = (from string s in Console.ReadLine().Split(new char[] { ' ' }) select int.Parse(s)).OrderBy(x => x).ToArray();
            int iterator = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[0] == nums[i])
                {
                    iterator++;
                }
            }
            Console.WriteLine("{0}", iterator);
        }
    }
}