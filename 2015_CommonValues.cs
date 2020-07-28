// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2015

using System;

class cslearning
{
    public static bool Simpler(int x)
    {
        for (int i = 2; i < x; i++)
            if ((x % i) == 0) return false;
        if (x == 1) return false;
        return true;

    }

    public void FindAllCommons()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (Simpler(i))
                Console.WriteLine(i);

        }
    }
}