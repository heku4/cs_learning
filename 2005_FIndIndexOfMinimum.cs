// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2005

using System;

namespace cs_learning
{
    class FindIndexOfMinimum
    {
        public void FindIndex()
        {
            Console.ReadLine();
            string[] stringSequence = Console.ReadLine().Split(' ');
            int[] sequence = Array.ConvertAll(stringSequence, int.Parse);
            int index = 0;
            int minInt = sequence[0];
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                
                if (minInt > sequence[i])
                {
                    minInt = sequence[i];
                    index = i;
                } 
            }
            Console.Write(index + 1);
        }
    }
}