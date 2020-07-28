// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2001

using System;

namespace cs_learning
{
    class AddB
    
    {
        public void Add()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int num = int.Parse(tokens[0]) + int.Parse(tokens[1]);
            string output = Convert.ToString(num);

            Console.WriteLine(output);
        }
    }
}