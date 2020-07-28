// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2004

using System;

namespace cs_learning
{
    class LeapYears
    {
        public void CheckLeapYear()
        {
            int yearNumber = int.Parse(Console.ReadLine());
            int isLeapYear = ((yearNumber % 4 == 0 && yearNumber % 100 != 0) || yearNumber % 400 == 0) ? 1 : 0;
            Console.Write(isLeapYear);
        }
    }
}