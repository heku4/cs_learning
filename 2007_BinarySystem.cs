// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2007

using System;

namespace cs_learning
{
    class BinarySystem
    {
        public void CalculateNulls()
        {
            int number = int.Parse(Console.ReadLine());
            int answer = 0;
            do
            {
                if (number % 2 == 1){
                    break;
                }
                int divided = number / 2;
                answer += 1;
                number = divided;
            } while ((number % 2) == 0);
            Console.Write(answer);
        }
    }
}