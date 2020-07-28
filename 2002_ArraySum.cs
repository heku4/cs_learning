// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2002

using System;

namespace cs_learning
{
    class ArraySum
    {
        public void CalculateSum()
        {
            Console.ReadLine();
            int answer = 0;
            string[] rightNums = Console.ReadLine().Split(' ');
            for (int i = 0; i < rightNums.Length; i++)
            {
                answer += int.Parse(rightNums[i]);
            }
            Console.WriteLine(Convert.ToString(answer));
        }
    }
}