// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2011

using System;

namespace cs_learning
{
    class AgeAnalysis
    {
        public void DefineAge()
        {
            int age = int.Parse(Console.ReadLine());

            if (age > 22)
            {
                Console.WriteLine("specialist");
            } else if (age < 23 && age > 17)
            {
                Console.Write("student {0}", age - 17);
            } else if (age < 18 && age > 6)
            {
                Console.Write("schoolchild {0}", age - 6);
            } else
            {
                Console.WriteLine("preschool child");
            }
        }
    }
}