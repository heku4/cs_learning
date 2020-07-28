// http://acm.sgu.ru/lang/problem.php?contest=2&problem=2019

using System;

namespace cs_learning
{
    class TriangleBookShelf
    {
        public void FindBook()
        {
            int bookNumber = int.Parse(Console.ReadLine());
            int currentShelf = 1;
            int finder = 0;

            while (finder < bookNumber)
            {
                if (finder + currentShelf >= bookNumber) break;
                else
                {
                    for (int i = 1; i <= currentShelf; i++)
                    {
                        finder += 1;
                    }
                    currentShelf++;
                }
            }
            Console.Write(currentShelf);
        }
    }
}