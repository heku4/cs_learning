// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2009

using System;
using System.Linq;

namespace cs_learning
{
    class BinaryDegreeIndex
    {
        public void Main()
        {
            Console.ReadLine();
            int[] sequence = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            
            int answer = 0;
            for (int i = 1; i <= sequence.Length; i *= 2)
            {
           
                answer += sequence[i-1];
            }
            Console.Write(answer);
        }
    }
}