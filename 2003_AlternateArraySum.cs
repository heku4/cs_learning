// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2003

using System;

namespace cs_learning
{
    class AlternateArraySum
    {
        public void CalculateSum()
        {
            Console.ReadLine();
            int answer = 0;
            string[] rightNums = Console.ReadLine().Split(' ');
            for (int i = 0; i < rightNums.Length; i++)
            {
                answer += int.Parse(rightNums[i]);
                if (i != (rightNums.Length - 1)) {
                    answer -= int.Parse(rightNums[i + 1]);
                    i++;
                }
            }
            Console.WriteLine(Convert.ToString(answer));
        }
    }
}